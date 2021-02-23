using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.IO;
using UnityEngine.SceneManagement;




public class TwitchChat : MonoBehaviour

{

    private TcpClient twitchClient;
    private StreamReader reader;
    private StreamWriter writer;

    public InputField usernamefield;
    public InputField channelfield;
    public InputField passwordfield;

    public Camera maincamera;

    public GameObject demon;
    public GameObject skeleton;

    public GameObject rat1;
    public GameObject rat2;
    public GameObject rat3;

    public GameObject originPoint;
    public GameObject spawner;

    public string username;
    public string password;
    public string channelName;

    void Start()
    {
        Connect();
        print("username");
        print("password");
        print("channelName");

        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (!twitchClient.Connected) 
        {
            Connect();
        }

        ReadChat();
        printInfo();
    }

    private void Connect() {
        twitchClient = new TcpClient("irc.chat.twitch.tv", 6667);
        reader = new StreamReader(twitchClient.GetStream());
        writer = new StreamWriter(twitchClient.GetStream());

        writer.WriteLine("PASS " + password);
        writer.WriteLine("NICK " + username);
        writer.WriteLine("USER " + username + " 8 * :" + username);
        writer.WriteLine("JOIN #" + channelName);
        writer.Flush();
    }

    private void ReadChat()
    {
        if (twitchClient.Available > 0)
        {
            var message = reader.ReadLine();

            if (message.Contains("PRIVMSG"))
            {
                var splitPoint = message.IndexOf("!", 1);
                var chatName = message.Substring(0, splitPoint);
                chatName = chatName.Substring(1);

                splitPoint = message.IndexOf(":", 1);
                message = message.Substring(splitPoint + 1);
                print(String.Format("{0}: {1}", chatName, message));

            }

            if(message.Contains("demon please")){

                GameObject.Instantiate(demon, originPoint.transform.position, originPoint.transform.rotation);

            
        }
            if (message.Contains("skeleton please"))
            {
                print("trying to print skellybob");
                
                
                GameObject.Instantiate(skeleton, originPoint.transform.position, originPoint.transform.rotation);


            }

            if (message.Contains("rat please"))
            {

                GameObject.Instantiate(rat1, originPoint.transform.position, originPoint.transform.rotation);


            }

            if (message.Contains("more rat please"))
            {

                GameObject.Instantiate(rat2, originPoint.transform.position, originPoint.transform.rotation);


            }

            if (message.Contains("MORE RAT"))
            {

                GameObject.Instantiate(rat3, originPoint.transform.position, originPoint.transform.rotation);


            }

        }
        
    }

    public void SetUsername() {

        username = usernamefield.text;
        print("username set to " + username);
    
    }
    public void SetChannelName()
    {

        channelName = channelfield.text;
        print("channel set to " + channelName);


    }
    public void SetPassword()
    {

        password = passwordfield.text;
        print("pass set to " + password);
    }

    public void StartGame() {

        SceneManager.LoadScene("Main Menu");

    }

    public void printInfo()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            print(username);
            print(channelName);
            print(password);
        }
    }
}
