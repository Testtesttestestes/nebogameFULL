using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Aprs.Controller.Filters
{
	// Token: 0x02000D76 RID: 3446
	[Token(Token = "0x2000D76")]
	public class AprOtherFilter : IAprFilter
	{
		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600547B RID: 21627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112B")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x600547A")]
			[Address(RVA = "0xA230", Offset = "0xA230", VA = "0xA230", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600547B")]
			[Address(RVA = "0xA231", Offset = "0xA231", VA = "0xA231", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x600547C")]
		[Address(RVA = "0xA232", Offset = "0xA232", VA = "0xA232", Slot = "6")]
		public bool Filter(AprData aprData)
		{
			return default(bool);
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547D")]
		[Address(RVA = "0xA233", Offset = "0xA233", VA = "0xA233")]
		public AprOtherFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		undefined4
		Gameplay_Aprs_Controller_Filters_AprOtherFilter__set_FilterInfo
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59477 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    DAT_ram_00a59477 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    return 1;
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param2 + 0x14) + 0x10);
		  if (*(int *)(Gameplay_Medals_Model_MedalUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Medals_Model_MedalUtils_TypeInfo);
		  }
		  uVar1 = Gameplay_Medals_Model_MedalTabBarItemData___ctor(uVar1,0);
		  return uVar1;
		}
		*/

}
