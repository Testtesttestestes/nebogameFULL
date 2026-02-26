using System;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Data;

namespace Core.Application.SO
{
	// Token: 0x02001244 RID: 4676
	[Token(Token = "0x2001244")]
	[Serializable]
	public class LevelPlaySettings
	{
		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700169A")]
		public string AppKey
		{
			[Token(Token = "0x6006ED4")]
			[Address(RVA = "0xB952", Offset = "0xB952", VA = "0xB952")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06006ED5 RID: 28373 RVA: 0x000143A0 File Offset: 0x000125A0
		[Token(Token = "0x1700169B")]
		public bool DebugAdapter
		{
			[Token(Token = "0x6006ED5")]
			[Address(RVA = "0xB953", Offset = "0xB953", VA = "0xB953")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06006ED6 RID: 28374 RVA: 0x000143B8 File Offset: 0x000125B8
		[Token(Token = "0x1700169C")]
		public bool ValidateIntegration
		{
			[Token(Token = "0x6006ED6")]
			[Address(RVA = "0xB954", Offset = "0xB954", VA = "0xB954")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06006ED7 RID: 28375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700169D")]
		public KeyValuePair<string, string>[] PostInitializeMetaData
		{
			[Token(Token = "0x6006ED7")]
			[Address(RVA = "0xB955", Offset = "0xB955", VA = "0xB955")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06006ED8 RID: 28376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700169E")]
		public KeyValuePair<string, string>[] PreInitializeMetaData
		{
			[Token(Token = "0x6006ED8")]
			[Address(RVA = "0xB956", Offset = "0xB956", VA = "0xB956")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06006ED9 RID: 28377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700169F")]
		public KeyValuePair<string, string>[] RewardedUnitIds
		{
			[Token(Token = "0x6006ED9")]
			[Address(RVA = "0xB957", Offset = "0xB957", VA = "0xB957")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x000143D0 File Offset: 0x000125D0
		[Token(Token = "0x6006EDA")]
		[Address(RVA = "0xB958", Offset = "0xB958", VA = "0xB958")]
		public bool IsTestSuiteAvail()
		{
			return default(bool);
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EDB")]
		[Address(RVA = "0xB959", Offset = "0xB959", VA = "0xB959")]
		public LevelPlaySettings()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_SO_LevelPlaySettings___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a807 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_SO_LevelPlaySettings___c_TypeInfo);
		    DAT_ram_00a5a807 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Application_SO_LevelPlaySettings___c_TypeInfo);
		  **(undefined4 **)(Core_Application_SO_LevelPlaySettings___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040039E9 RID: 14825
		[Token(Token = "0x40039E9")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private string _appKey;

		// Token: 0x040039EA RID: 14826
		[Token(Token = "0x40039EA")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private bool _validateIntegration;

		// Token: 0x040039EB RID: 14827
		[Token(Token = "0x40039EB")]
		[FieldOffset(Offset = "0xD")]
		[SerializeField]
		private bool _debugAdapter;

		// Token: 0x040039EC RID: 14828
		[Token(Token = "0x40039EC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private KeyValuePair<string, string>[] _preInitializeMetaData;

		// Token: 0x040039ED RID: 14829
		[Token(Token = "0x40039ED")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private KeyValuePair<string, string>[] _postInitializeMetaData;

		// Token: 0x040039EE RID: 14830
		[Token(Token = "0x40039EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyValuePair<string, string>[] _rewardedUnitIds;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardedUnitIds ---
		undefined4 Core_Application_SO_LevelPlaySettings__get_RewardedUnitIds(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a806 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_KeyValuePair_string__string____)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_KeyValuePair_string__string___bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Application_SO_LevelPlaySettings___c__IsTestSuiteAvail_b__18_0__);
		    Mono_Security_ASN1__get_Item(&Core_Application_SO_LevelPlaySettings___c_TypeInfo);
		    DAT_ram_00a5a806 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_Application_SO_LevelPlaySettings___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Application_SO_LevelPlaySettings___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Application_SO_LevelPlaySettings___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Application_SO_LevelPlaySettings___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Application_SO_LevelPlaySettings___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Application_SO_LevelPlaySettings___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_KeyValuePair_string__string___bool__TypeInfo);
		    System_Func_KeyValuePair_ulong__object___bool___Invoke
		              (param1_00,param2_00,
		               Method_Core_Application_SO_LevelPlaySettings___c__IsTestSuiteAvail_b__18_0__,0);
		    *(int *)(*(int *)(Core_Application_SO_LevelPlaySettings___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Any_KeyValuePair_object__object__
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Any_KeyValuePair_string__string____);
		  return uVar1;
		}
		*/

}
