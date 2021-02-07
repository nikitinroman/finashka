import vk_api
import threading
from datetime import datetime
from vk_api.longpoll import VkLongPoll, VkEventType
from vk_api.bot_longpoll import *
from vk_api.utils import get_random_id
import psycopg2
import pandas as pd
weekdays = {1:"monday", 2:"tuesday", 3:"wednesday", 4:"thursday", 5:"friday", 6:"saturday", 7:"sunday"}


con = psycopg2.connect(
  database="postgres",
  user="postgres",
  password="154278",
  host="127.0.0.1",
  port="5432"
)

db = pd.read_sql_query('select * from school',con=con)
db = db.set_index('id').T.to_dict('list')


def schedule(date, klass):
    if date == "sunday":
        return "В воскресенье, вроде как, не учимся!)"
    else:
        sched = pd.read_csv(f'{date}.csv', delimiter=';')
        msg = ""
        for i in sched[f"{klass}"]:
            if i != 'nan':
                msg += str(i) + "\n"
        return str(msg)
        # sched = pd.read_csv(f'{date}.csv', delimiter=';')
        # return(str(sched[f"{klass}"].T.to_dict()))


def drop(id):
    cur = con.cursor()
    cur.execute(f"DELETE FROM school WHERE id = {id}")
    con.commit()
    db = pd.read_sql_query('select * from school', con=con)
    db = db.set_index('id').T.to_dict('list')
    users_list.pop(users_list.index(id))



def log(id, text, klass = " "):
  date = datetime.now()
  row = f"{date} , {id} , {klass} , {text} " + '\n'
  with open("log.txt", 'a') as file:
    file.write(row)


def add_into_database(id,klass):
    try:
        check_klass = int(klass[1])
        cur = con.cursor()
        cur.execute(f"INSERT INTO school (id, class) VALUES ({id}, {klass})")
        con.commit()
        vk.messages.send(user_id=id, random_id=get_random_id(),
                       message=f"Успешно добавлено, Ваш класс: {klass}")
    except:
        vk.messages.send(user_id=id, random_id=get_random_id(),
                         message="Вводите необходимые данные корректно и на русской раскладке клавиатуры!!")



users_list = []



def menu(db):
    if event.from_user and event.user_id in db:
        id = event.user_id
        klass = db[id][0]
        try:
            if 'привет' == event.text.lower() or 'помощь' == event.text.lower() or 'что' in event.text.lower() or 'как' in event.text.lower():
                vk.messages.send(user_id=event.user_id, random_id=get_random_id(),
                                 message="Для получения расписания введите сегодня- на сегодня, завтра- на завтра, неделя- на неделю. Для смены класса- писать сменить или изменить. При возникновении проблем- писать https://vk.com/nikitin_roman_420")
            elif 'сменить класс' == event.text.lower() or 'сменить' == event.text.lower() or 'изменить' in event.text.lower() or 'изменить класс' in event.text.lower():
                drop(id)
                vk.messages.send(user_id=event.user_id, random_id=get_random_id(),
                                 message="Введите ваш класс в формате: 11В")
            elif 'расписание на сегодня' == event.text.lower() or 'сегодня' == event.text.lower() or 'на сегодня' in event.text.lower() or 'ctujlyz' in event.text.lower():
                now = datetime.isoweekday(datetime.now())
                vk.messages.send(user_id=event.user_id, random_id=get_random_id(),
                                 message=schedule(weekdays[now], klass))
            elif 'расписание на завтра' == event.text.lower() or 'завтра' == event.text.lower() or 'на завтра' in event.text.lower() or 'pfdnhf' in event.text.lower():
                now = datetime.isoweekday(datetime.now()) + 1
                vk.messages.send(user_id=event.user_id, random_id=get_random_id(),
                                 message=schedule(weekdays[now], klass))
            elif 'расписание на неделю' == event.text.lower() or 'неделя' == event.text.lower() or 'на неделю' in event.text.lower() or 'недельное' in event.text.lower() or 'ytltkz' in event.text.lower():
                str_week = ""
                for i in range(1, 8):
                    str_week += weekdays[i] + '\n' + schedule(weekdays[i], klass) + '\n'
                vk.messages.send(user_id=event.user_id, random_id=get_random_id(),
                                 message=str_week)
            # vk.messages.send(user_id=id, random_id=get_random_id(),
            #                message=""Для получения расписания введите сегодня- на сегодня, завтра- на завтра, неделя- на неделю. При возникновении проблем- писать https://vk.com/nikitin_roman_420"")
        except:
            vk.messages.send(user_id=id, random_id=get_random_id(),
                             message="Введите еще раз последнее действие!")
    elif event.from_user and event.user_id not in db and event.user_id not in users_list:
        users_list.append(event.user_id)
        vk.messages.send(user_id=event.user_id, random_id=get_random_id(),
                         message="Введите ваш класс в формате: 11В")
    elif event.from_user and event.user_id not in db and event.user_id in users_list:
        if len(event.text) <= 3:
            klass = event.text.upper()
            klass = "'" + klass + "'"
            add_into_database(event.user_id, klass)
            vk.messages.send(user_id=event.user_id, random_id=get_random_id(),
                             message="Для получения расписания введите сегодня- на сегодня, завтра- на завтра, неделя- на неделю. Для смены класса- писать сменить или изменить. При возникновении проблем- писать https://vk.com/nikitin_roman_420")




vk_session = vk_api.VkApi(token='3fbb16e6dac55037d4b27f27a8515ca77103e129bd5e4c02284d9d550069231e06a0d5c403282b1092a3b')
longpoll = VkLongPoll(vk_session)
vk = vk_session.get_api()
for event in longpoll.listen():
    if event.type == VkEventType.MESSAGE_NEW and event.to_me and event.text:
        menu(db)
        db = pd.read_sql_query('select * from school', con=con)
        db = db.set_index('id').T.to_dict('list')

