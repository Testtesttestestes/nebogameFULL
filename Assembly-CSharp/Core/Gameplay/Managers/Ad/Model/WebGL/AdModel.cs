using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Services;

namespace Core.Gameplay.Managers.Ad.Model.WebGL
{
	// Token: 0x02001224 RID: 4644
	[Token(Token = "0x2001224")]
	public class AdModel : AbstractAdModel
	{
		// Token: 0x06006DF9 RID: 28153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DF9")]
		[Address(RVA = "0xB8AF", Offset = "0xB8AF", VA = "0xB8AF")]
		public AdModel(IGame game, UserData user)
		{
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06006DFA RID: 28154 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001657")]
		public override uint[] SupportedAdProviders
		{
			[Token(Token = "0x6006DFA")]
			[Address(RVA = "0xB8B0", Offset = "0xB8B0", VA = "0xB8B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DFB")]
		[Address(RVA = "0xB8B1", Offset = "0xB8B1", VA = "0xB8B1")]
		public void InitSupportedAds(params AdSource[] ads)
		{
		/* --- GHIDRA: InitSupportedAds ---
		void Core_Gameplay_Managers_Ad_Model_WebGL_AdModel__InitSupportedAds(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a7be == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo);
		    DAT_ram_00a5a7be = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04003985 RID: 14725
		[Token(Token = "0x4003985")]
		[FieldOffset(Offset = "0x20")]
		private uint[] _supportedAdProviders;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SupportedAdProviders ---
		void Core_Gameplay_Managers_Ad_Model_WebGL_AdModel__get_SupportedAdProviders
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a5a7bd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_AdSource__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_AdSource__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c__InitSupportedAds_b__4_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo);
		    DAT_ram_00a5a7bd = '\x01';
		  }
		  if (*(int *)(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_AdSource__uint__TypeInfo);
		    System_Func_Int32Enum__float___Invoke
		              (param1_00,uVar1,
		               Method_Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c__InitSupportedAds_b__4_0__,0
		              );
		    *(int *)(*(int *)(Core_Gameplay_Managers_Ad_Model_WebGL_AdModel___c_TypeInfo + 0x5c) + 4) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,param1_00,Method_System_Linq_Enumerable_Select_AdSource__uint___);
		  uVar1 = System_Linq_Enumerable__OrderBy_uint__uint_
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_uint___);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

}
