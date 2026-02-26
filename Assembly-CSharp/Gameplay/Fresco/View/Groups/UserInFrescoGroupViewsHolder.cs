using System;
using Il2CppDummyDll;
using UI;
using UI.Elements.GenericList;

namespace Gameplay.Fresco.View.Groups
{
	// Token: 0x020007FF RID: 2047
	[Token(Token = "0x20007FF")]
	public class UserInFrescoGroupViewsHolder : ItemViewsHolder<FrescoGroupListElement>
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003006")]
		[Address(RVA = "0x806C", Offset = "0x806C", VA = "0x806C", Slot = "13")]
		public override void SetData(GenericListElementArgs args)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Fresco_View_Groups_UserInFrescoGroupViewsHolder__SetData
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57582 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_FrescoGroupListElement___ctor__);
		    DAT_ram_00a57582 = '\x01';
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003007 RID: 12295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003007")]
		[Address(RVA = "0x806D", Offset = "0x806D", VA = "0x806D")]
		public UserInFrescoGroupViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Fresco_View_Groups_UserInFrescoGroupViewsHolder___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_8 = *(undefined8 *)(param1 + 0x30);
		  local_10 = *(undefined8 *)(param1 + 0x28);
		  uVar1 = UnityEngine_ColorUtility__DoTryParseHtmlColor(&local_10,0);
		  return uVar1;
		}
		*/

		}
	}
}
