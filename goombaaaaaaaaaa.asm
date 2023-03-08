org 100h

jmp start
goomba db "GOOMB", 0

start:
mov dx, goomba
mov ah, 9
int 21h
loop:
  mov al, 'A'
  mov ah, 0x0E
  int 10h
  jmp loop
