import json
import csv
from datetime import datetime


def read_file():
    tovar = {}
    users_list = {}
    zakaz_list = {}
    tovar_stat = {}
    with open('tovar.json', 'r') as file:
        tovar = json.load(file)
    with open('users_list.json', 'r') as file:
        users_list = json.load(file)
    with open('zakaz_list.json', 'r') as file:
        zakaz_list = json.load(file)
    return users_list, tovar, zakaz_list


def write_file(filename):
    with open(filename, 'w') as file:
        if filename == 'tovar.json':
            json.dump(tovar, file)
        elif filename == 'users_list.json':
            json.dump(users_list, file)
        elif filename == 'tovar_stat.json':
            json.dump(tovar, file)
        else:
            json.dump(zakaz_list, file)


username = ''
users_list, tovar, zakaz_list = read_file()


def login():
    username_ = input('Введите имя пользователя ')
    if username_ in users_list:
        password = input('Введите пароль ')
        if users_list[username_]['password'] == password:
            global username
            username = username_
            return users_list[username]['is_admin']
        else:
            print('Ошибка. Не верный пароль')
            return None
    else:
        print('Такого пользователя нет')
        return None


def add_user():
    username = input('Введите имя пользователя: ')
    if username in users_list:
        print('Такой пользователь уже есть')
    else:
        password = input('Введите пароль ')
        is_admin = input('True/False ')
        is_admin = True if is_admin == 'True' else False
        users_list.update({username: {'password': password, 'is_admin': is_admin, 'zakazu': 0}})
        write_file('users_list.json')


def add_tovar():
    product = input('Введите наименование товара ')
    if product in tovar:
        print('Данный товар уже есть')
    else:
        price = input('Введите цену товара ')
        tovar.update({product: {'price': price, 'stats': 0}})
        write_file('tovar.json')


def oformlenie():
    print('Ваш заказ?')
    print(tovar)
    global summa
    summa = 0
    zakaz = []
    pokupki = []
    t_time = str(datetime.now())
    eda = 1
    new_zakaz = {}
    i = 0
    for i in range(10):
        if eda != 0:
            eda = input('Введите название того, что вы выбрали! Хотите выйти- введите 0')
            if eda in tovar:
                pokupki.append(eda)
                zakaz.append(eda)
                zakaz.append(tovar[eda])
                zakaz.append(tovar[eda]['price'])
                summa += int(tovar[eda]['price'])
                tovar[eda]['stats'] += 1
                print('Сумма заказа:', summa, zakaz)

            else:
                print('Такого товара нет или вы ввели 0')
                break
    i += 1
    users_list[username]['zakazu'] += 1
    write_file('users_list.json')
    new_zakaz.update({i: {'pokupki': pokupki, 'time': t_time, 'sotrudnik_id': username, 'summa': summa}})
    zakaz_list.update(new_zakaz)
    write_file('zakaz_list.json')
    write_file('tovar.json')
    write_file('tovar_stat.json')


def statistica(isCsv=False):
    stat1 = 0
    stat2 = 10000000
    stat3 = 0
    dorogoy = 0
    deshevuy = 1000
    max_zakaz = 0
    min_zakaz = 0
    kolvo_zakazov = int(len(zakaz_list))
    summa_zakazov = 0
    sredniy_chek = 0
    for prod in tovar:
        if tovar[prod]['stats'] > stat1:
            stat1 = tovar[prod]['stats']
            max_zakaz = prod
        if tovar[prod]['stats'] < stat2:
            stat2 = tovar[prod]['stats']
            min_zakaz = prod
    for zakaz in zakaz_list:
        summa_zakazov += int(zakaz_list[zakaz]['summa'])
    sredniy_chek = (int(summa_zakazov)) / kolvo_zakazov
    sum_for_prod = {}
    kolvo_for_prod = {}
    for zakaz in zakaz_list:
        sum_for_prod.update({zakaz_list[zakaz]['sotrudnik_id']: sum_for_prod.get(zakaz_list[zakaz]['sotrudnik_id'],
                                                                                 0) + int(zakaz_list[zakaz]['summa'])})
        kolvo_for_prod.update(
            {zakaz_list[zakaz]['sotrudnik_id']: kolvo_for_prod.get(zakaz_list[zakaz]['sotrudnik_id'], 0) + 1})
    sredniy_chek_for_prod = {name: sum_for_prod[name] / kolvo_for_prod[name] for name in kolvo_for_prod.keys()}
    for prod in tovar:
        if int(tovar[prod]['price']) > int(dorogoy):
            dorogoy = tovar[prod]['price']
        if int(tovar[prod]['price']) < int(deshevuy):
            deshevuy = tovar[prod]['price']

    print(f'Самый популярный товар: {max_zakaz}')
    print(f'Самый не популярный товар: {min_zakaz}')
    print(f'Средний чек: {sredniy_chek}, Самый дорогой товар: {dorogoy}')
    print(f'Самый дешёвый товар: {deshevuy}')
    print(f'Сумма за все заказы у сотрудников: {sum_for_prod}')
    print(f'Кол-во заказов заказов у сотрудников: {kolvo_for_prod}')
    print(f'Средний чек у сотрудников: {sredniy_chek_for_prod}')
    write_file('tovar.json')
    if isCsv:
        FILENAME = "stats.csv"

        users = [
            ["Самый популярный товар", max_zakaz],
            ["Самый не популярный товар", min_zakaz],
            ["Средний чек", sredniy_chek],
            ["Самый дорогой товар", dorogoy],
            ["Самый дешёвый товар", deshevuy],
            ["Сумма за все заказы у сотрудников", sum_for_prod],
            ["Кол-во заказов заказов у сотрудников", kolvo_for_prod],
            ["Средний чек у сотрудников", sredniy_chek_for_prod]
        ]

        with open(FILENAME, "w", newline="") as file:
            writer = csv.writer(file, delimiter=';')
            writer.writerows(users)


def udalenie():
    print(tovar)
    delete = input('Введите наименование товара, который хотите удалить ')
    del tovar[delete]
    write_file('tovar.json')


def sotrudnik():
    stat1 = 0
    stat2 = 1000
    user1 = 0
    user2 = 0
    max_prod = 0
    min_prod = 0
    for sotr in users_list:
        if users_list[sotr]['zakazu'] > stat1:
            stat1 = users_list[sotr]['zakazu']
            user1 = sotr
        if users_list[sotr]['zakazu'] < stat2:
            stat2 = users_list[sotr]['zakazu']
            user2 = sotr
    print('Лучший сотрудник месяца:', user1, stat1, 'Худший сотрудник месяца:', user2, stat2)


def menu():
    is_admin = None
    while is_admin is None:
        is_admin = login()
    comanda = 10
    while comanda != 0:
        if is_admin:
            print('1- Вывод статистики по заказам\n',
                  '2- Регистрация нового пользователя\n',
                  '3- Добавление новых товаров\n',
                  '4- Удаление товаров из продажи\n',
                  '5- Оформить заказ\n',
                  '6- Лучший и худший сотрудники\n',
                  '0- Выход из программы'
                  )
            comanda = int(input('Введите ваш выбор '))
            if comanda == 1:
                isCsv = bool(input('Сохранить в csv? (True/False)'))
                statistica(isCsv)
            elif comanda == 2:
                add_user()
            elif comanda == 3:
                add_tovar()
            elif comanda == 4:
                udalenie()
            elif comanda == 5:
                oformlenie()
            elif comanda == 6:
                sotrudnik()
        else:
            comanda = 10
            while comanda != 0:
                print('1- Оформить заказ\n',
                      '0- Выйти из программы')
                comanda = int(input('Введите ваш выбор '))
                if comanda == 1:
                    oformlenie()


menu()
