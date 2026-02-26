using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012FC RID: 4860
	[Token(Token = "0x20012FC")]
	[Serializable]
	public class CloudWorldObjectEngineArgs : WorldObjectEngineArgs
	{
		// Token: 0x060073AA RID: 29610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073AA")]
		[Address(RVA = "0xBD91", Offset = "0xBD91", VA = "0xBD91", Slot = "4")]
		public override IWorldObjectEngine GetEngine()
		{
		/* --- GHIDRA: GetEngine ---
		void CloudsFly_CloudWorldObjectEngineArgs__GetEngine(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59682 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Sprite___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Sprite__TypeInfo);
		    DAT_ram_00a59682 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Sprite__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Sprite___ctor__);
		  *(undefined4 *)(param1 + 0x4c) = param1_00;
		  ScreenAdaptation_Common_AppSize__Update(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073AB")]
		[Address(RVA = "0xBD92", Offset = "0xBD92", VA = "0xBD92")]
		public CloudWorldObjectEngineArgs()
		{
		/* --- GHIDRA: .ctor ---
		void CloudsFly_CloudWorldObjectEngineArgs___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59683 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudsHorizonLineFitter_OnGameContentScaledEvent__);
		    DAT_ram_00a59683 = '\x01';
		  }
		  if (DAT_ram_00a5b8f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b8f1 = '\x01';
		  }
		  param1_01 = **(undefined4 **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_CloudsFly_CloudsHorizonLineFitter_OnGameContentScaledEvent__,0)
		  ;
		  ScreenAdaptation_Scale_GameScaler__add_GameContentScaledEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04003C90 RID: 15504
		[Token(Token = "0x4003C90")]
		[FieldOffset(Offset = "0x44")]
		public Transform tiledCloudsContainer;

		// Token: 0x04003C91 RID: 15505
		[Token(Token = "0x4003C91")]
		[FieldOffset(Offset = "0x48")]
		public TiledCloudSpriteWorldObject tiledCloudSpritePrefab;

		// Token: 0x04003C92 RID: 15506
		[Token(Token = "0x4003C92")]
		[FieldOffset(Offset = "0x4C")]
		public List<Sprite> tiledSprites;

		// Token: 0x04003C93 RID: 15507
		[Token(Token = "0x4003C93")]
		[FieldOffset(Offset = "0x50")]
		public float cloudStepDistance;
	}
}
