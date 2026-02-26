using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Google.Impl
{
	// Token: 0x020013D4 RID: 5076
	[Token(Token = "0x20013D4")]
	public class SignInHelperObject : MonoBehaviour
	{
		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06007909 RID: 30985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017F7")]
		internal static SignInHelperObject Instance
		{
			[Token(Token = "0x6007909")]
			[Address(RVA = "0xC247", Offset = "0xC247", VA = "0xC247")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600790A")]
		[Address(RVA = "0xC248", Offset = "0xC248", VA = "0xC248")]
		public SignInHelperObject()
		{
		/* --- GHIDRA: .ctor ---
		void Google_Impl_SignInHelperObject___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a54ea0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_AddComponent_GAFBakedObjectController___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject_TypeInfo);
		    DAT_ram_00a54ea0 = '\x01';
		  }
		  if (DAT_ram_00a54ea1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a54ea1 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 == 0) {
		    uVar3 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		    uVar2 = unnamed_function_1417(UnityEngine_GameObject_TypeInfo);
		    func_ii_13018(uVar2,uVar3,0);
		    uVar3 = UnityEngine_UI_Selectable__set_interactable(uVar2,0);
		    param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (*(undefined4 *)(*(int *)(param1 + 8) + 0xc),0);
		    UnityEngine_Transform__get_parent(uVar3,param2_00,0);
		    uVar3 = UnityEngine_UI_Selectable__set_interactable(uVar2,0);
		    local_18 = *(undefined8 *)(*(int *)(param1 + 8) + 0x2c);
		    local_4 = 0;
		    local_10 = 0;
		    local_c = local_18;
		    Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar3,&local_18,0);
		    uVar2 = UnityEngine_GameObject__GetComponent_object_
		                      (uVar2,Method_UnityEngine_GameObject_AddComponent_GAFBakedObjectController___)
		    ;
		    *(undefined4 *)(param1 + 0x10) = uVar2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x04003F3B RID: 16187
		[Token(Token = "0x4003F3B")]
		[FieldOffset(Offset = "0x0")]
		private static SignInHelperObject instance;
	}
}
