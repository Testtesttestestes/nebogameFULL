using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path
{
	// Token: 0x020011E0 RID: 4576
	[Token(Token = "0x20011E0")]
	public class MenuSettings : AbstractPathNode
	{
		// Token: 0x06006CD1 RID: 27857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD1")]
		[Address(RVA = "0xB7BD", Offset = "0xB7BD", VA = "0xB7BD", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD2")]
		[Address(RVA = "0xB7BE", Offset = "0xB7BE", VA = "0xB7BE", Slot = "6")]
		protected override void TransitionCanceled()
		{
		}

		// Token: 0x06006CD3 RID: 27859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CD3")]
		[Address(RVA = "0xB7BF", Offset = "0xB7BF", VA = "0xB7BF")]
		public MenuSettings()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_MenuSettings___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a727 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12324);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19448);
		    DAT_ram_00a5a727 = '\x01';
		  }
		  param1_00 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                        (StringLiteral_12324,*(undefined4 *)(param1 + 8),StringLiteral_19448,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  func_ii_7830(param1_00,0);
		  Core_ExternAppMethods__OpenPaymentWindow
		            (param3,param4,Method_Utils_OpToken_LocatorPayload__AbstractPathNode__Complete__);
		  return;
		}
		*/

		}
	}
}
