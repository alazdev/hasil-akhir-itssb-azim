package com.lksn.weather;

import android.util.Log;

import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

import javax.net.ssl.HttpsURLConnection;

public class HttpHandler {
    public static final String TAG = HttpHandler.class.getSimpleName();

    public HttpHandler(){}

    public String makeServiceCall(String r_url){
        String response = null;
        try{
            URL url = new URL(r_url);
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");

            InputStream in = new BufferedInputStream(conn.getInputStream());
            response = convertStreamToString(in);
        }catch (Exception ex){
            Log.e(TAG, "Error makeServiceCall : " + ex.getMessage());
        }
        return response;
    }
    private String convertStreamToString(InputStream in){
        StringBuilder sb = new StringBuilder();
        try{
            BufferedReader read = new BufferedReader(new InputStreamReader(in));

            String line;
            while ((line = read.readLine()) != null){
                sb.append(line).append("\n");
            }
        }catch (Exception ex){
            Log.e(TAG, "Error convertStreamToString : " + ex.getMessage());
        }finally {
            try {
                in.close();
            }catch (Exception ex){
                Log.e(TAG, "InputStream Error : " + ex.getMessage());
            }
        }
        return sb.toString();
    }
}
