import socket
import os
import shutil
from threading import Thread

"""
pwd - сервер возвращает название рабочей папки
ls - показывает содержимое рабочей папки
cat <filename> - показать содержимое папки
mkdir <filename> - создание папки
rm <filename> - удаление файла
rmdir <direct_name> - удаление папки
rename <filename new_filename> - переименование файла
выполнил Никитин Роман выполнил Никитин Роман.
copy <filename1 filename2> копирует с сервера файл на клиент
push <filename1 filename2> копирует filename2 с клиента на сервер в filename1
chdir <dir_name> переходит в папку, указанную пользователем, работает и с ..
"""

#curr_dir = os.path.join(os.getcwd(), 'docs')
server_addr = os.path.join(os.getcwd())
lst = []


def process(req):
    global new_curr_dir
    new_curr_dir = ''
    if req == 'pwd':
        return curr_dir
    elif req == 'ls':
        lord = ''
        lord = '; '.join(os.listdir(curr_dir))
        if lord != '':
            return '; '.join(os.listdir(curr_dir))
        else:
            return "Пусто!"
    elif req[:4] == 'cat ':
        filename = os.path.join(os.getcwd(), req[4:])
        #filename = curr_dir + '/' + req[4:]
        with open(filename, 'r') as file:
            return file.read()
    elif req[:6] == 'mkdir ':
        filename = os.path.join(os.getcwd(), req[6:])
        print(filename)
        os.mkdir(filename)
        return filename
    elif req[:3] == 'rm ':
        if req[3:] != 'log.txt':
            try:
                filename = os.path.join(os.getcwd(), req[3:])
                os.remove(filename)
                result = filename + ' deleted!'
                return result
            except:
                return 'No such file'
        elif login == 'admin':
            try:
                filename = os.path.join(os.getcwd(), req[3:])
                os.remove(filename)
                result = filename + ' deleted!'
                return result
            except:
                return 'No such file'
        return 'НИЗЗЯ УДАЛЯТЬ LOG.TXT!'
    elif req[:6] == 'rmdir ':
        filename = os.path.join(os.getcwd(), req[6:])
        shutil.rmtree(filename)
        result = filename + ' deleted!'
        return result
    elif req[:7] == 'rename ':
        if req.split()[1] != 'log.txt' and req.split()[2] != 'log.tst':
            filename1 = os.path.join(os.getcwd(), req.split()[1])
            filename2 = os.path.join(os.getcwd(), req.split()[2])
            try:
                os.rename(filename1, filename2)
                return 'renamed!'
            except:
                return 'Oshibka!'
        else:
            return 'НИЗЗЗЯ ПЕРЕИМЕНОВЫВАТЬ ФАЙЛ LOG.TXT И НАЗЫВАТЬ ТАК НОВЫЙ!'
    elif req[:5] == 'copy ':
        filename1 = os.path.join(os.getcwd(),  req.split()[2])
        filename2 = os.path.join(server_addr, req.split()[1])
        shutil.copyfile(filename2, filename1)
        return 'ready!'
    elif req[:5] == 'push ':
        filename1 = os.path.join(os.getcwd(),  req.split()[2])
        filename2 = os.path.join(server_addr, req.split()[1])
        shutil.copyfile(filename1, filename2)
        return 'ready!'
    elif req[:6] == 'chdir ':
        try:
            if req[6:] == "..":
                os.chdir('..')
                new_curr_dir = os.path.join(os.getcwd())
                new_now = new_curr_dir.split('\\')
                if new_now[-1] != str(login) and login != "admin":
                    os.chdir(main_curr_dir)
                    new_curr_dir = main_curr_dir
                    return 'Не Балуй!!!'
                return new_curr_dir
            else:
                dir = os.path.join(os.getcwd(), str(req[6:]))
                os.chdir(dir)
                new_curr_dir = os.path.join(os.getcwd())
            return new_curr_dir
        except:
            return 'No such directory!'
    else:
        return 'bad request'


PORT = 12345
sock = socket.socket()
sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
sock.bind(('localhost', PORT))
sock.listen(10)
conn, addr = sock.accept()
suck = 'Success'
lose = 'Error, press 0 to retry or 1 for create new login and password'


def log():
    flag = 0
    global login
    login = conn.recv(1024).decode()
    password = conn.recv(1024).decode()
    with open('log_pass.txt') as file:
        for row in file:
            elements = row.split(' ')
            if str(elements[0]) == str(login) and str(elements[1]) == (str(password) + '\n'):
                flag += 1
                conn.send(suck.encode())
                answer = 3
                return answer
        if flag == 0:
            conn.send(lose.encode())
            #print(login, password)
            answer = conn.recv(1024).decode()
            return answer


while True:
    print('Bыполнил Никитин Роман выполнил Никитин Роман')
    answ = log()
    while True:
        if str(answ) == '0':
            log()
        if answ == 3:
            print('Прошел авторизацию')
            break
        elif str(answ) == '1':
            login = conn.recv(1024).decode()
            if login == "admin":
                login = "default_user"
                conn.send(login.encode())
                print(login)
            password = conn.recv(1024).decode()
            new_row = str(login) + ' ' + str(password) + '\n'
            #os.chdir('..')
            with open('log_pass.txt', 'a') as file:
                file.write(new_row)
                break
        else:
            break
    #way = 'docs' + "/" + str(login)
    way = os.path.join(os.getcwd(), 'docs')
    way1 = os.path.join(way, str(login))
    curr_dir = way1    #################
    main_curr_dir = curr_dir
    try:
        os.chdir(curr_dir)
        # os.chdir('..')
    except:
        os.mkdir(curr_dir)
        os.chdir(curr_dir)
        with open('log.txt', 'a') as file:
            file.write('File with user log\n')
        os.chdir('..')

    #print(server_addr)
    #print(curr_dir)
    while True:
        request = conn.recv(1024).decode()
        print(request)
        #print(curr_dir)
        if request != 'close':
            os.chdir(main_curr_dir)
            with open('log.txt', 'a') as file:
                file.write(request + '\n')
            os.chdir(curr_dir)
            response = process(request)

            if new_curr_dir != '':
                curr_dir = new_curr_dir
            conn.send(response.encode())
        else:
            conn.close()
            break
