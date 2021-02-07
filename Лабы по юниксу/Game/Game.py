import sys, pygame
import random

pygame.init()
H = 600
W = 1200
lol = 0
score_1 = 1
score_2 = 0
screen = pygame.display.set_mode((W, H))
white = (255, 255, 255)
pygame.display.set_caption('Mashinki')
time = pygame.time.Clock()
group = pygame.sprite.Group()
car_group = pygame.sprite.Group()
myimage = pygame.image.load("karta.jpg")
myimage_lol = pygame.image.load("ricardo.jpg")
imagerect = myimage.get_rect()
imagerect_lol = myimage_lol.get_rect()


class Cars(pygame.sprite.Sprite):
    def __init__(self, x, y):
        super().__init__(group, car_group)
        if lol < 9:
            self.image = pygame.image.load('car1.png')
        else:
            self.image = pygame.image.load('trollface.jpg')
        self.rect = self.image.get_rect()
        self.rect.x = x
        self.rect.y = y
        self.speed = 10
        self.direction = 'right'

    def update(self):
        if self.direction == 'right':
            self.rect.x += self.speed
            if self.rect.x > W - 147:
                self.direction = 'left'
        else:
            self.rect.x -= self.speed
            if self.rect.x < 0:
                self.direction = 'right'


class Star(pygame.sprite.Sprite):
    def __init__(self, x, y):
        super().__init__(group)
        self.image = pygame.image.load('finish.png')
        self.rect = self.image.get_rect()
        self.rect.x = x
        self.rect.y = y


class Player(pygame.sprite.Sprite):
    def __init__(self, x, y):
        super().__init__(group)
        self.image = pygame.image.load('frog.jpg')
        self.rect = self.image.get_rect()
        self.rect.x = x
        self.rect.y = y
        self.speed = 20
        self.last = pygame.time.get_ticks()

    def update(self):
        keys = pygame.key.get_pressed()
        if keys[pygame.K_RIGHT] and self.rect.x <= W - (self.speed + 60):
            self.rect.x += self.speed
        if keys[pygame.K_RIGHT] and self.rect.x > W - (self.speed + 60):
            self.rect.x = W - 85
        if keys[pygame.K_LEFT] and self.rect.x >= 0 + self.speed:
            self.rect.x -= self.speed
        if keys[pygame.K_LEFT] and self.rect.x <= 0 + self.speed:
            self.rect.x = 0
        if keys[pygame.K_UP] and self.rect.y >= 0 + self.speed:
            self.rect.y -= self.speed
        if keys[pygame.K_UP] and self.rect.y < 0 + self.speed:
            self.rect.y = 0
        if keys[pygame.K_DOWN] and self.rect.y <= H - (self.speed + 70):
            self.rect.y += self.speed
        if keys[pygame.K_DOWN] and self.rect.y > H - (self.speed + 70):
            self.rect.y = H - 85
        car_crash = pygame.sprite.spritecollide(self, car_group, False)
        global score_1
        global score_2
        global lol
        if len(car_crash):
            self.rect.x = 0
            self.rect.y = 0
        star_win_1 = pygame.sprite.collide_rect(self, star_1)
        if star_win_1 and pygame.time.get_ticks() - self.last > 1500 and score_1 < score_2:
            score_1 += 2
            lol += 1
            [Cars(random.randint(1, W - 147), random.randint(100, H - 217)) for _ in range(2)]
            self.last = pygame.time.get_ticks()
            self.speed += 5
        star_win_2 = pygame.sprite.collide_rect(self, star_2)
        if star_win_2 and pygame.time.get_ticks() - self.last > 1500 and score_2 < score_1:
            score_2 += 2
            lol += 1
            [Cars(random.randint(1, W - 147), random.randint(100, H - 217)) for _ in range(2)]
            self.last = pygame.time.get_ticks()
            self.speed += 5


[Cars(random.randint(1, W - 147), random.randint(100, H - 217)) for _ in range(8)]
star_1 = Star(550, 1)
star_2 = Star(550, 500)
player = Player(1, 1)

while lol != 10:
    time.tick(30)
    group.draw(screen)
    group.update()
    pygame.display.flip()
    screen.fill(white)
    if lol < 9:
        screen.blit(myimage, imagerect)
    else:
        screen.blit(myimage_lol, imagerect_lol)
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            sys.exit()
