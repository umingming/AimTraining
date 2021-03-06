package kr.co.aim.server;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Scanner;

/*
	에코 서버
	- 서버를 생성하고 클라이언트의 접근을 확인해 스레드 생성
 */
public class Server {
	private ServerSocket server;
	private Socket client;
	private ArrayList<ClientGroup> groupList = new ArrayList<>();
	
	private int index;
	
	/*
		생성자 정의
		1. while문 server가 null이면 반복해서 setServer() 호출함.
		2. server 설정이 되면, start() 호출
	 */		
	public Server() {
		while(server == null) {
			registerServer();
		}
		start();
	}
	
	
	/*
		setServer(); 서버 생성
		1. 입력 값을 port에 저장
		2. port를 매개로 서버소켓 생성 후 안내 메시지 출력
		3. 그룹 두 개 생성함.
		4. 예외처리
			> port 넘버를 잘못 입력했을 경우
			> 이미 존재하는 port의 경우
	 */
	private void registerServer() {
		try {
			Scanner scanner = new Scanner(System.in);
			
			System.out.print("[서버 생성] Port 번호를 입력하세요. \n ☞ ");
			int port = scanner.nextInt();
			
			server = new ServerSocket(port);
			System.out.printf("[서버 생성 성공] Port 번호는 %d입니다.%n"
								, server.getLocalPort());
			
			createGroup(2);
			createGroup(2);
			
			scanner.close();
			
		} catch (Exception e) {
			System.out.println("[서버 생성 실패] 잘못된 입력입니다.");
		} 
	}
	
	/*
	 	createGroup; 그룹 생성
	 	1. 매개변수를 크기로 하는 그룹 객체 생성함.
	 	2. 해당 그룹을 리스트에 저장
	 */
	private void createGroup(int total) {
		ClientGroup group = new ClientGroup(total);
		groupList.add(group);
	}
	
	/*
		start(); 클라이언트의 접속을 확인하고 스레드 생성
		1. while문 그룹이 2개 이하일 경우 반복
			> 클라이언트 접근 확인 후 client 소켓에 초기화
			> 스레드 선언 후 run 메소드 오버라이딩
				> 클라이언트와, 그룹을 연결하기 위한 메소드 호출
			> 스레드를 시작함.
			> if 해당 그룹이 만원인지?
				> index++
	 */
	private void start() {
		try {
			while(groupList.size() < 3) {
				client = server.accept();
				System.out.println("[사용자 접속 대기]");
				
				if(groupList.get(index).isFull()) {
					index++;
				}
				
				ServerThread serverThread = new ServerThread(client, groupList.get(index));
				Thread thread = new Thread(serverThread);
				thread.start();
			}
		} catch (IOException e) {
			System.out.println("[사용자 접속 실패]");
		}
	}

	/*
		메인 메소드
		1. 생성자 호출
	 */
	public static void main(String[] args) {
		try {
			new Server();
			
		} catch(Exception e) {
			System.out.println("[시스템 오류] 접속을 강제 종료합니다.");
			e.printStackTrace();
			System.exit(0);
		}
	}
}