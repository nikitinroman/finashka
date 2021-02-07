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
        # return server_addr
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


PORT = 12344
sock = socket.socket()
sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
sock.bind(('localhost', PORT))
sock.listen(10)
conn, addr = sock.accept()
print(conn, addr)

suck = 'success'
lose = 'Error, press 0 to retry or 1 for create new login and password'
login = conn.recv(1024).decode()
password = conn.recv(1024).decode()
#strok = str(addr[0])
passwd = str(password) + '\n'
with open('address_log.txt', 'r') as file:
    for line in file:
        line1 = line.split(';')
        if login == line1[0] and passwd == line1[1]:
            print("Hello, dude")
            break
    else:
        print("nevernuy parol ili novuy user")

with open('address_log.txt', 'a', encoding = 'utf-8') as file:
    file.write(str(addr[0]) + ';' + str(passwd))
with open('server_log.txt', 'a', encoding = 'utf-8') as file:
    file.write(str(addr) + '  ' + 'connected\n')


print(login, password)


while True:
    request = conn.recv(1024).decode()
    print(request)

    if request != 'close':
        response = process(request)
        conn.send(response.encode())
    else:
        conn.close()
        break
