import socket

sock = socket.socket()
HOST = 'localhost'
PORT = 10000
sock.connect((HOST, PORT))

while True:
    msg1 = input()
    if msg1 != 'close':
        sock.send(msg1.encode())
    msg = sock.recv(4096)
    print(msg.decode())

sock.close()
