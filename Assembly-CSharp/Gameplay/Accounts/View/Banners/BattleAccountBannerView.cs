using System;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Accounts.View.Banners
{
	// Token: 0x02000DD1 RID: 3537
	[Token(Token = "0x2000DD1")]
	public class BattleAccountBannerView : AbstractAccountBannerView<BattleAccount>
	{
		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x1700118A")]
		public override uint AccountId
		{
			[Token(Token = "0x6005646")]
			[Address(RVA = "0xA3D4", Offset = "0xA3D4", VA = "0xA3D4", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005647")]
		[Address(RVA = "0xA3D5", Offset = "0xA3D5", VA = "0xA3D5")]
		public BattleAccountBannerView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Accounts_View_Banners_BattleAccountBannerView___ctor
		          (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a588a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2480);
		    DAT_ram_00a588a2 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_2480,1,0,1,0,0,0,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param3_00 = Utils_TimeUtils__DateFormat((double)param2,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_118,param3_00,0);
		  return uVar1;
		}
		*/

		}
	}
}
