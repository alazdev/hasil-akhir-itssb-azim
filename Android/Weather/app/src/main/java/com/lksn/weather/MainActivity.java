package com.lksn.weather;

import androidx.appcompat.app.AppCompatActivity;

import android.app.ProgressDialog;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.HashMap;

public class MainActivity extends AppCompatActivity {
    private static final String TAG = MainActivity.class.getSimpleName();

    private ProgressDialog pDialog;
    private ListView lsv;
    private TextView data_1, data_2, data_3, data_4;

    private static String url = "http://18.140.243.251/api/v1/weathers/forecast?lat=-6.164713&lon=106.725050";
    private static String url2 = "http://18.140.243.251/api/v1/weathers/current?lat=-6.164713&lon=106.725050";

    ArrayList<HashMap<String, String>> getDataList;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        getDataList = new ArrayList<>();
        lsv = (ListView) findViewById(R.id.lsv);
        data_1 = (TextView) findViewById(R.id.data_1);

        new GetDataList().execute();
    }

    public void Login(View view) {
        startActivity(new Intent(MainActivity.this, LoginActivity.class));
    }

    public void upload(View view) {
        startActivity(new Intent(MainActivity.this, UploadTemperatureActivity.class));
    }

    private class GetDataList extends AsyncTask<Void, Void, Void>{
        @Override
        protected void onPreExecute() {
            super.onPreExecute();

            pDialog = new ProgressDialog(MainActivity.this);
            pDialog.setMessage("Please Wait");
            pDialog.setCancelable(false);
            pDialog.show();
        }

        @Override
        protected Void doInBackground(Void... voids) {
            try{
                HttpHandler ht = new HttpHandler();
                String response = ht.makeServiceCall(url);
                if(response != null){
                    JSONObject jsonObj = new JSONObject(response);
                    JSONObject jsonObjData = jsonObj.getJSONObject("data");
                    JSONArray jsonArry = jsonObjData.getJSONArray("hourly");

                    for(int i = 0; i < 6; i++){
                        JSONObject t = jsonArry.getJSONObject(i);

                        String data = t.getString("dt");
                        int number = Integer.parseInt(data);
                        String data2 = t.getInt("temp") + " C/" + t.getInt("feels_like") + " C";

                        HashMap<String, String> dataList = new HashMap<>();

                        dataList.put("data", Integer.toString(number));
                        dataList.put("data2", data2);
                        getDataList.add(dataList);
                    }
                }else{
                    Log.e(TAG, "JSON could't found");
                    runOnUiThread(new Runnable() {
                        @Override
                        public void run() {
                            Toast.makeText(getApplicationContext(),
                                    "JSON could't found",
                                    Toast.LENGTH_LONG
                            ).show();
                        }
                    });
                }
            }catch (Exception ex){
                Log.e(TAG, "JSON parse Error : " +ex.getMessage());
                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        Toast.makeText(getApplicationContext(),
                                "JSON parse Error : " +ex.getMessage(),
                                Toast.LENGTH_LONG
                        ).show();
                    }
                });
            }
            return null;
        }

        @Override
        protected void onPostExecute(Void aVoid) {
            super.onPostExecute(aVoid);

            if(pDialog.isShowing())
                pDialog.dismiss();

            ListAdapter la = new SimpleAdapter(
                    MainActivity.this, getDataList,
                    R.layout.item_list_view_forecast, new String[]{"data","data2"},
                    new int[]{R.id.data1,R.id.data2}
            );

            lsv.setAdapter(la);
        }
    }
}