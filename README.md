# Idle-NPC-with-Aggression [TVX Games (Mad Diamond)]

Unity 2020.1.x/Shooter/Mobile/PC

![GitHub License](https://img.shields.io/github/license/IRONKAGE/Idle-NPC-with-Aggression?style=plastic) ![GitHub Code Size](https://img.shields.io/github/languages/code-size/IRONKAGE/Idle-NPC-with-Aggression?style=plastic) ![Languges](https://img.shields.io/github/languages/count/IRONKAGE/Idle-NPC-with-Aggression?style=plastic)

## About Game

🎲 **Task:**
Write a simple NPC (visual is not important, you can use dice). NPC has two states - calm (idle) and aggression (aggressive).

🎮 **Mechanics:**

- In calmness, the NPC moves from point to point, taking a break for a random amount of time (within);
- In aggression, the NPC pursues the target, and if it is close enough, it attacks it with a shot, if the target moves, then the NPC continues to pursue until it destroys the target. If the target is destroyed, the NPC goes into the idle state.

🍭 **Game description:**
The target for the NPC is another NPC that has only one idle state, just like the first NPC. That is, he walks back and forth with stops. He can take damage and die at the hands of the first NPC.

Switching the states of the first NPC must be done through the Unity GUI. Those. there should be a button that preemptively transfers the NPC from one state to another

## Images

![Game](/ScreenShots/AgressionNPC.jpg)

## Tasks in the original language

```
Написать простого NPC (визуал не важен, можно на кубиках).
NPC имеет два состояния - спокойствие (idle) и агрессия (aggressive).
1) В спокойствии NPC передвигается от точки до точки, делая передышку на рандомное количество времени (в пределах).
2) В агрессии NPC преследует цель, и если находится достаточно близко - атакует ее выстрелом, если цель движется, то NPC продолжает преследовать, пока не уничтожит цель. Если цель уничтожена, NPC переходит в состояние idle.

Цель для NPC - другой NPC, который имеет только одно состояние idle, в точности как у первого NPC. То есть ходит туда-сюда с остановками. Он может получать урон и умереть от рук первого NPC.

Переключение состояний первого NPC обязательно сделать через Unity GUI. Т.е. должна быть кнопка, которая превентивно переводит NPC из одного состояние в другое.
```
