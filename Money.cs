using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;


/******************************************************************************************  
 ****************************************         *********************************** 
 ******************************************************************************************/
public class Money : MonoBehaviour {

	
	public Text moneyText_m;
	public int money_m;
	
	private string moneyfilePath = "Assets/Resources/Scripts/BlockShopScript/MyMoney.csv";  

	void Start () {
		ReadMyMoney ();
		moneyText_m.text = money_m.ToString();
	}

	public void setTextValue(){
		
		SaveMyMoney ();
		moneyText_m.text = money_m.ToString();
		
	}

	void SaveMyMoney(){
		
		File.WriteAllText(moneyfilePath, money_m.ToString()); 
		
	}
	
	void ReadMyMoney(){
		
		string filetext = File.ReadAllText(moneyfilePath);
		money_m = int.Parse (filetext);
		
	}
}
