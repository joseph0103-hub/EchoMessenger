# C# 코딩 - 에코 메신저

## 1. 프로젝트 개요

본 프로젝트는 **C# Windows Forms**를 사용하여 만든 간단한 **에코 메신저 프로그램**입니다.  
사용자가 입력한 메시지를 버튼 클릭으로 화면에 출력하는 방식으로 구현하였습니다.

에코 메신저는 사용자가 입력한 내용을 그대로 다시 보여주는 프로그램으로,  
이번 실습에서는 **텍스트 입력 처리**, **버튼 클릭 이벤트 처리**, **리스트박스 출력**,  
**입력창 초기화 및 포커스 이동** 기능을 중심으로 구현하였습니다.

---

## 2. 개발 환경

- Language : C#
- Framework : .NET Windows Forms
- IDE : Visual Studio 2026
- Version Control : GitHub

---

## 과제 1. 실행 화면
### 과제 1-1. 기본 실행 화면
![기본](img/Assignment_1_main.png)

### 과제 1-2. 메시지 입력
![입력](img/Assignment_1_input.png)

### 과제 1-3. 메시지 출력
![출력](img/Assignment_1_output.png)

## 과제 1. 사용한 컨트롤

본 프로젝트에서는 Windows Forms의 기본 컨트롤을 활용하여 화면을 구성하였습니다.

- **Label**
  - 프로그램 제목인 `EchoMessege`를 화면 상단에 출력하기 위해 사용
- **TextBox**
  - 사용자가 메시지를 입력하기 위해 사용
- **ListBox**
  - 입력한 메시지를 목록 형태로 출력하기 위해 사용
- **Button**
  - 입력한 메시지를 전송하는 기능을 수행하기 위해 사용

---

## 과제 1. 구현한 기능

### 과제 1-1. 메시지 입력 기능
사용자가 하단의 텍스트박스(`txtmsg`)에 원하는 문장을 입력할 수 있도록 구현하였습니다.

### 과제 1-2. 버튼 클릭 시 메시지 출력 기능
버튼(`button1`)을 클릭하면 텍스트박스에 입력된 문자열을 읽어와  
리스트박스(`listBox1`)에 추가되도록 구현하였습니다.

### 과제 1-3. 입력창 초기화 기능
메시지가 전송된 뒤에는 기존 입력 내용을 지우기 위해  
`txtmsg.Clear();` 코드를 사용하여 입력창을 비우도록 하였습니다.

### 과제 1-4. 포커스 이동 기능
메시지를 전송한 뒤 사용자가 다시 바로 입력할 수 있도록  
`txtmsg.Focus();` 코드를 사용하여 커서를 입력창으로 다시 이동시켰습니다.

---

## 과제 1. 소스 코드 설명

버튼 클릭 이벤트의 핵심 코드는 아래와 같습니다.

private void button1_Click(object sender, EventArgs e)
{
    string typed_msg;
    typed_msg = txtmsg.Text;
    listBox1.Items.Add(typed_msg);
    txtmsg.Clear();
    txtmsg.Focus();
}