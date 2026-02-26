using System;
using System.Runtime.CompilerServices;
using AppsFlyerSDK;
using Il2CppDummyDll;

namespace Platforms.Android.AppsFlyer
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	public class ConversionListener
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CD")]
		public ConversationDataComponent Component
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x5B64", Offset = "0x5B64", VA = "0x5B64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x5B65", Offset = "0x5B65", VA = "0x5B65")]
		public ConversionListener(IAppsFlyerConversionData conversionDataDecorator)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Component ---
		void Platforms_Android_AppsFlyer_ConversionListener__get_Component
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5b848 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_GameObject_AddComponent_ConversationDataComponent___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3180);
		    DAT_ram_00a5b848 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_GameObject_TypeInfo);
		  func_ii_13018(param1_00,StringLiteral_3180,0);
		  iVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (param1_00,
		                     Method_UnityEngine_GameObject_AddComponent_ConversationDataComponent___);
		  *(int *)(param1 + 8) = iVar1;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Object__FindObjectsByType(param1_00,0);
		  return;
		}
		*/

}
