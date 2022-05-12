package kr.co.aim.tcp;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ConnectException;
import java.net.Socket;
import java.util.Scanner;

public class MultiClient2 {
	public static void main(String[] args) {
		if(args.length != 1) {
			System.out.println("USAGE: java MultiClient 대화명");
			System.exit(0);
		}
		
		try {
			String serverIp = "127.0.0.1";
			Socket socket = new Socket(serverIp, 2214);
			System.out.println("서버에 연결되었습니다.");
			Thread sender = new Thread(new ClientSender(socket, args[0]));
			Thread receiver = new Thread(new ClientReceiver(socket));
			
			sender.start();
			receiver.start();
		} catch(ConnectException ce) {
			ce.printStackTrace();
		} catch(Exception e) {
			e.printStackTrace();
		}
	}
	
	static class ClientSender extends Thread {
		Socket socket;
		DataOutputStream out;
		String name;
		
		ClientSender(Socket socket, String name) {
			this.socket = socket;
			try {
				out = new DataOutputStream(socket.getOutputStream());
				this.name = name;
			} catch(Exception e) {
				e.printStackTrace();
			}
		}
		
		public void run() {
			Scanner scanner = new Scanner(System.in);
			try {
				if(out != null) {
					out.writeUTF(name);
				}
				while(out != null) {
					out.writeUTF("[" + name + "]" + scanner.nextLine());
				}
			} catch(IOException e) {
				e.printStackTrace();
			}
		}
	}
	
	static class ClientReceiver extends Thread {
		Socket socket;
		DataInputStream in;
		
		public ClientReceiver(Socket socket) {
			this.socket = socket;
			try {
				in = new DataInputStream(socket.getInputStream());
			} catch(IOException e) {
				e.printStackTrace();
			}
		}
		
		public void run() {
			while(in != null) {
				try {
					System.out.println(in.readUTF());
				} catch(IOException e) {
					e.printStackTrace();
				}
			}
		}
	}
}
