import socket
from select import select

server = socket.socket()
server.bind(('localhost', 10000))
server.listen(0)
monitoring = []
lol = []


def connection(server):
    client, addr = server.accept()
    lol.append(client)
    print("Connection from", addr)
    monitoring.append(client)
    msg = 'Hello. dude!'
    client.send(msg.encode())


def writer(client):
    data = client.recv(4096)
    if data.decode() == 'close':
        client.close()
    else:
        #client.send(data)
        for i in lol:
            i.send(data)



def event_loop():
    while True:
        ready_to_read,  _, _ = select(monitoring, [], [])
        for i in ready_to_read:
            if i == server:
                connection(i)
            else:
                writer(i)


if __name__ == '__main__':
    monitoring.append(server)
    event_loop()



