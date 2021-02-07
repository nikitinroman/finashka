from bs4 import BeautifulSoup
import requests
import csv

URL = "https://cars.av.by/filter?price_currency=2&page="
HEADERS = {
    "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36 OPR/73.0.3856.344"}

def writeCsv(comps):
    with open("Parser.csv", 'w', newline='', encoding="utf-8") as csvfile:
        writer = csv.writer(csvfile, delimiter=";")
        for comp in comps:
            writer.writerow([str(comp["Name"]),
                             str(comp["Price"]),
                             str(comp["Year"]),
                             str(comp["Transmission"]),
                             str(comp["Volume"]),
                             str(comp["Fuel"]),
                             str(comp["Mileage"])
            ])

def parse():
    count = 0
    comps = []
    for i in range(1, 150):
        count += 1
        response = requests.get(URL + str(i), headers=HEADERS)
        soup = BeautifulSoup(response.content, "html.parser")
        items = soup.findAll("div", class_="listing-item")
        for item in items:

            info = item.find("div", class_="listing-item__params").get_text(strip=True)

            splited_info = info.replace("\xa0", '').replace(",", ' ').replace("г.", ' ').split(' ')

            if splited_info[1][0] == "а":
                transmission = "auto"
            else:
                transmission = "mech"

            if splited_info[2] == "электро":
                volume = "-"
                fuel = "Elec"
            else:
                volume = splited_info[2][0:len(splited_info[2])-1]
                if splited_info[3][0] == "б":
                    fuel = "Benz"
                else:
                    fuel = "Diz"

            mileage = info[len(info) - 10:len(info) - 3].replace(" ", '')
            while not mileage.isdigit():
                mileage = mileage[1::1]

            comps.append({
                "Name": item.find("span", class_="link-text").get_text(strip=True),
                "Price": item.find("div", class_="listing-item__price").get_text(strip=True)[0:len(item.find("div", class_="listing-item__price").get_text(strip=True)) - 3],
                "Year": item.find("div", class_="listing-item__params").get_text(strip=True)[0:4],
                "Transmission": transmission,
                "Volume": volume,
                "Fuel": fuel,
                "Mileage": mileage
            })
        print(count)

    writeCsv(comps)
    #for comp in comps:
    #    print(comp["Mileage"])


if __name__ == '__main__':
    parse()
