import turtle
import colorsys

t = turtle.Turtle()
s = turtle.Screen()
s.bgcolor('black')
t.pencolor('red')
t.speed(0)

for i in range(291):
    t.circle(190-i, 90)
    t.lt(90)
    t.circle(190-i, 90)
    t.lt(18)        