# STOCK_DATA_US
```
학점연계형 체험 인턴을 진행하며 AI 자산운용시스템인  Robo-Advisor HighBuff를 함께 개발하는 프로젝트에 참여했습니다. 

금융사 API를 이용해 미국거래소인 나스닥, NYSE 총 2곳에서 거래되는 모든 종목별 

시가, 종가, 고가, 저가 등의 종목데이터를 수집하고 저장하는 역할을 담당했습니다. 

AI 엔진을 통해 종목별로 데이터를 분석하여 단기적으로 수익 발생 가능 종목별 매수/매도 시점을 예측 후  해당시점에 자동 매매 시스템입니다.

```

### 일시    
+ 2019.03 ~ 2019.6 (3개월)

<br/>
 

### 개발환경 및 언어
<img src="https://img.shields.io/badge/API-5C2D91?style=for-the-badge&logo=API&logoColor=white"/> <img src="https://img.shields.io/badge/CShap-ED2224?style=for-the-badge&logo=HTML5&logoColor=white"/> 
<img src="https://img.shields.io/badge/MongoDB-009639?style=for-the-badge&logo=MongoDB&logoColor=white"/>
<img src="https://img.shields.io/badge/Python-333333?style=for-the-badge&logo=Python&logoColor=white"/>
<img src="https://img.shields.io/badge/Git-FCC624?style=for-the-badge&logo=Git&logoColor=white"/>


<br/>

### 개발기능
+ 증권사 API를 통한 미국거래소의 금일 거래 종목 리스트 받아오기
+ 장 개장시간에 맞춰 데이터 스트리밍 System 스케줄링 (자동 로그인, 6,000여 종목 Data Streaming)
+ Python COM버전 API를 이용한 실시간 빅데이터 Mongo DB에 수집
+ 데이터 군집화, 가중치 계산 등 어드바이징 시스템을 통한 거래 종목분석
+ 기준치 로스컷을 설정하여 손실 발생 시 자동매매를 통한 손실 최소화
+ 장 마감 후 백 테스팅을 통한 수익종목 모의투자로 기계학습
+ Pyplot을 이용한 종목별 수집데이터를 이용한 일봉 차트 도출


<br/>

### Deploy 

AI ROBO-Advisor 웹앱 : 

<img src="https://github.com/BangJihoon/STOCK_DATA_US/blob/master/deploy.png" width="512px"/>

<br/>

주식 데이터 스트리밍 영상 : 

https://user-images.githubusercontent.com/26866859/152375389-5a260dd1-e31f-4559-8b6a-4bed9fdcba79.mp4
