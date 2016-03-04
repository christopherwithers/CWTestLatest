// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using System;
using UnityEngine;
using System.Collections.Generic;
using Assets.Alis;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("JsonFetch. Some foo here etc")]
	public class JsonFetch : GUIContentAction
	{
		public FsmEvent sendEvent;
		[UIHint(UIHint.Variable)]
		public FsmBool storeButtonState;

        [UIHint(UIHint.FsmString)]
	    public FsmString jsonUrl;

	    private JsonHandler jsonHandler = new JsonHandler();
	
		public override void Reset()
		{
			base.Reset();
			sendEvent = null;
		   // jsonFetch = null;
			storeButtonState = null;
			style = "Button";
		}
		
		public override void OnGUI()
		{
			base.OnGUI();
			
			bool pressed = false;

            
			
			if (GUI.Button(rect, content, style.Value))
            {
                throw new Exception(jsonUrl.Value);

                var tester = jsonHandler.GetTrad(jsonUrl.Value);
                Fsm.Event(sendEvent);
				pressed = true;

 

			    var tt = tester;
			}
			
			if (storeButtonState != null)
			{
				storeButtonState.Value = pressed;
			}
		}
	}
}