import socket
import os
import shutil
from threading import Thread

"""
pwd - сервер возвращает название рабочей папки
ls - показывает содержимое рабочей папки
cat <filename> - показать содержимое папки
mkdir <filename> - создание папки
"""

curr_dir = os.path.join(os.getcwd(), 'docs')
server_addr = os.path.join(os.getcwd())
lst = []


def process(req):
    if req == 'pwd':
        return curr_dir
    elif req == 'ls':
        return '; '.join(os.listdir(curr_dir))
    elif req[:4] == 'cat ':
        filename = curr_dir + '/' + req[4:]
        with open(filename, 'r') as file:
            return file.read()
    elif req[:6] == 'mkdir ':
        filename = curr_dir + '/' + req[6:]
        os.mkdir(filename)
        return filename
    elif req[:3] == 'rm ':
        try:
            filename = curr_dir + '/' + req[3:]
            os.remove(filename)
            result = filename + ' deleted!'
            return result
        except:
            return 'No file'
    elif req[:6] == 'rmdir ':
        filename = curr_dir + '/' + req[6:]
        os.removedirs(filename)
        result = filename + ' deleted!'
        return result
    elif req[:7] == 'rename ':
        filename1 = curr_dir + '/' + req.split()[1]
        filename2 = curr_dir + '/' + req.split()[2]
        os.renames(filename1, filename2)
        return 'renamed!'
    elif req[:5] == 'copy ':
        filename1 = curr_dir + '/' + req.split()[1]
        filename2 = server_addr + '/' + req.split()[2]
        shutil.copyfile(filename1, filename2)
        return 'ready!'
    elif req[:5] == 'push ':
        filename2 = curr_dir + '/' + req.split()[2]
        filename1 = server_addr + '/' + req.split()[1]
        shutil.copyfile(filename1, filename2)
        return 'ready!'
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
#flag = 0

def log():
    flag = 0
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
            print(login, password)
            answer = conn.recv(1024).decode()
            return answer

answ = log()

while True:
    if str(answ) == '0':
        log()
    if answ == 3:
        print('прошел авторизацию')
        break
    elif str(answ) == '1':
        login = conn.recv(1024).decode()
        password = conn.recv(1024).decode()
        new_row = str(login) + ' ' + str(password) + '\n'
        with open('log_pass.txt', 'a') as file:
            file.write(new_row)
            break
    else:
        print('Выход в 107 строке')
        break


#conn, addr = sock.accept()


while True:
    request = conn.recv(1024).decode()
    print(request)

    if request != 'close':
        response = process(request)
        with open('log.txt', 'a') as file:
            file.write(request + '\n')
        conn.send(response.encode())
    else:
        conn.close()
        break
