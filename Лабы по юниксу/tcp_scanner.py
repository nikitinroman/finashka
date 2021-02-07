import sys
import socket
import time


from threading import Thread
from multiprocessing.dummy import Pool as ThreadPool


class PortScanner(Thread):

    def __init__(self, start_port: int = 1, end_port: int = 65535, host: str = "localhost"):
        """
        Порт сканер
        """

        super(PortScanner, self).__init__()

        self.start_port = start_port
        self.end_port = end_port
        self.host = host
        self.progress = 0
        # self.progress_bar = ProgressBar(100)
        # self.progress_bar.prefix_text = 'Cканирование портов: '
        self.is_scan = dict()

    def run(self) -> None:
        """
        Срабатывает при запуске сканера

        :return:
        """

        start = time.time()

        pool = ThreadPool(1000)
        pool.map(self.scanner, range(self.start_port, self.end_port))
        pool.close()
        pool.join()
        print(self.is_scan)
        end = time.time()
        print(end - start)
        # for i in range(1, steps + 1):
        #     sleep(0.2)


        # progress_bar.complete()
        # for item in sorted(self.is_scan.items(), key=lambda x: x[0]):
        #     if item[1] is True:
        #         print(f"Порт {item[0]} открыт")

    # def progress_bar(self):


    def scanner(self, port: int):
        """
        Проверяет порт

        :param port:
        :return:
        """

        sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        try:
            sock.bind((self.host, port))
            sock.close()
            self.is_scan[port] = True
            return port
        except OSError:
            self.is_scan[port] = False
        self.progress += 1
        # self.progress_bar.show(self.progress)


if __name__ == '__main__':
    port_scanner = PortScanner()
    port_scanner.start()
    print("Готово")



