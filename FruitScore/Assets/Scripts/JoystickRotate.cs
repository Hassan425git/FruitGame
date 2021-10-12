using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


namespace GeekGame.Input{
	public class JoystickRotate : JoystickMove
	{

		public static JoystickRotate instance;



		void Awake(){

			if(instance!=null){
				Destroy(this.gameObject);
			}else{
				instance=this;
			}

		}



	}
}