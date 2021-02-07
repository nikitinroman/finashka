import json


def read_all_files():
    tasks_list_ = {}
    logins_list_ = {}
    with open('task_list.json', 'r') as tasks:
        tasks_list_ = json.load(tasks)
    with open('logins.json', 'r') as logins:
        logins_list_ = json.load(logins)
    return tasks_list_, logins_list_


def write_all_files(task_list, logins_list):
    with open('task_list.json', 'w') as tasks:
        json.dump(task_list, tasks)
    with open('logins.json', 'w') as logins:
        json.dump(logins_list, logins)


tasks_list, logins_list = read_all_files()


def login():
    username = input('Введите имя пользователя: ')
    if username in logins_list:
        password = input('Введите пароль: ')
        if logins_list[username]['password'] == password:
            return (username, logins_list[username]['is_admin'])
        else:
            print('Пароль не верный')
            raise ValueError
    else:
        print('Такой пользователь не зарегестрирован')
        raise ValueError


def add_user(username, password='defaultpassword', is_admin=False):
    if username in logins_list:
        raise ValueError('Такой пользователь уже есть')
    logins_list.update({username: {'password': password, 'is_admin': is_admin}})


def add_task(username, task_text):
    tasks_list.update({username: tasks_list.get(username, []) + [
        {'task_text': task_text, 'task_result': '', 'task_status': 'given'}]})


def complete_task(username, task_id, task_result):
    tasks_list[username][task_id]['task_result'] = task_result
    tasks_list[username][task_id]['task_status'] = 'done'


def verify_task(username, task_id):
    print(f'Подтвердить выполнение задачи? (y/n)')
    inp = input()
    if inp == 'y':
        tasks_list[username][task_id]['task_status'] = 'verified'
    elif inp == 'n':
        return
    else:
        verify_task(username, task_id)


def check_input_int(message, limit):
    while True:
        try:
            inp = int(input(message))
            if 0 <= inp < limit:
                return inp
            else:
                raise ValueError
        except ValueError:
            print('Неверный ввод')


def show_tasks(username):
    print('-' * 30)
    print(f'Задачи для {username}')
    if username not in tasks_list:
        print('У данного пользователя нет задач')
        return False
    for task_index in range(len(tasks_list[username])):
        print(f'ID: {task_index}, Задача: {tasks_list[username][task_index]["task_text"]}, '
              f'Статус: {tasks_list[username][task_index]["task_status"]}, '
              f'Результат: {tasks_list[username][task_index]["task_result"]}')
    return True


loop = True


def show_menu(is_admin):
    print('-' * 30)
    print('Выбирите действие')
    print('1 Посмотреть задачи')
    print('2 Отправить результат')
    if is_admin:
        print('3 Назначить задачу')
        print('4 Подтвердить выполнение задачи')
        print('5 Добавить нового пользователя')
    print('0 Выход из программы')
    inp = check_input_int('Введите номер комманды: ', 6 if is_admin else 3)
    print('-' * 30)
    if inp == 1:
        show_tasks(username)
        show_menu(is_admin)
    elif inp == 2:
        has_tasks = show_tasks(username)
        if username in tasks_list and has_tasks:
            task_id = check_input_int('Введите ID нужной задачи: ', len(tasks_list[username]))
            if tasks_list[username][task_id]['task_status'] != 'verified':
                print('Введите результат задачи')
                task_result = input()
                complete_task(username, task_id, task_result)
            write_all_files(tasks_list, logins_list)
    elif inp == 3 and is_admin:
        usernames_dic = {index: name for index, name in enumerate(logins_list.keys())}
        for index, name in usernames_dic.items():
            print(f'{index} {name}')
        username_ = usernames_dic[check_input_int('Введите ID пользователя: ', len(usernames_dic))]
        print('Введите задачу')
        task_text = input()
        add_task(username_, task_text)
        write_all_files(tasks_list, logins_list)
    elif inp == 4 and is_admin:
        usernames_dic = {index: name for index, name in enumerate(logins_list.keys())}
        for index, name in usernames_dic.items():
            print(f'{index} {name}')
        username_ = usernames_dic[check_input_int('Введите ID пользователя: ', len(usernames_dic))]
        has_tasks = show_tasks(username_)
        if has_tasks:
            task_id = check_input_int('Введите ID нужной задачи: ', len(tasks_list[username_]))
            verify_task(username_, task_id)
            write_all_files(tasks_list, logins_list)
    elif inp == 5 and is_admin:
        username_ = input('Введите имя нового пользователя: ')
        password = input('Введите пароль: ')
        print('Админ?')
        is_admin_ = True if input() == 'y' else False
        add_user(username_, password, is_admin)
        write_all_files(tasks_list, logins_list)
    elif inp == 0:
        global loop
        loop = False


print('Добро пожаловать в менеджер задач')
print('Вы должны войти в систему для того, чтобы воспользоваться данным инструментом')
username, is_admin = '', ''
while not str(is_admin):
    try:
        username, is_admin = login()
    except:
        pass
while loop:
    try:
        show_menu(is_admin)
    except ValueError as error:
        print(f'!!! {error} !!!')
write_all_files(tasks_list, logins_list)
