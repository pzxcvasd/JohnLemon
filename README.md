# JohnLemon's Haunted Jaunt
Unity Learn 제공 "JohnLemon's Haunted Jaunt" 프로젝트 튜토리얼
</br>
적을 피해 성에서 탈출하는 3D 스텔스 게임

## 튜토리얼 기능 구현

### 1. 플레이어 애니메이션 구현
움직임이 있을 때와 없을 때의 동작을 다르게 구현

<img src="https://github.com/yonsoo-seo/JohnLemon/assets/99024754/e76e5414-9e54-45e3-80b7-90213669f750" width="350">

### 2. 적 캐릭터 구현 : 정적/동적 관찰자
가고일 : 움직임이 없는 정적 관찰자. 가고일과 일정거리만큼 가까워지면 감지됨 -> 게임 종료

<img src="https://github.com/yonsoo-seo/JohnLemon/assets/99024754/97131c79-97b7-4a03-b773-673c811eaa12">
</br>
</br>
유령 : 일정한 패턴으로 움직이는 정적 관찰자. 유령과 닿으면 게임 종료
</br>
<img src="https://github.com/yonsoo-seo/JohnLemon/assets/99024754/85ad4e44-0b12-4d1a-bad6-1f323468e541" width="250">

## 튜토리얼 외 기능 구현

### 1. 추가 미션 기능
맵 구석구석에 음식 5개 배치.
</br>
단순히 적을 피하는 것 뿐만아니라 맵 전반적으로 많은 숨은 공간을 활용해 미션을 새로 구현함.

![food](https://github.com/yonsoo-seo/JohnLemon/assets/99024754/9e061fc8-c14f-44bf-a527-cc82f60335ad)

### 2. 팝업 메시지 구현
기존에는 적을 피해 탈출만 하면 성공 화면을 띄웠는데, 미션 기능을 새로 구현하면서 </br>
해당 미션을 클리어하지 못할 경우, 탈출을 할 수 없고 팝업 메시지가 띄워지도록 함.

<img src="https://github.com/yonsoo-seo/JohnLemon/assets/99024754/8034267c-48a2-43b8-8423-438041c6d369" width="300">
<img src = "https://github.com/yonsoo-seo/JohnLemon/assets/99024754/8ad194c2-abfb-4ea4-892f-c4b724a255b0" width = "500">
