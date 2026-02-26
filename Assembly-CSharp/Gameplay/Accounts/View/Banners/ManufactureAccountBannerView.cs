using System;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Accounts.View.Banners
{
	// Token: 0x02000DD3 RID: 3539
	[Token(Token = "0x2000DD3")]
	public class ManufactureAccountBannerView : AbstractAccountBannerView<ManufactureAccount>
	{
		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x0600564A RID: 22090 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x1700118B")]
		public override uint AccountId
		{
			[Token(Token = "0x600564A")]
			[Address(RVA = "0xA3D8", Offset = "0xA3D8", VA = "0xA3D8", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600564B")]
		[Address(RVA = "0xA3D9", Offset = "0xA3D9", VA = "0xA3D9", Slot = "12")]
		protected override string FormatBacktimeCallback(float value)
		{
		/* --- GHIDRA: FormatBacktimeCallback ---
		void Gameplay_Accounts_View_Banners_ManufactureAccountBannerView__FormatBacktimeCallback
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a588a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_View_Banners_AbstractAccountBannerView_ManufactureAccount___ctor__
		              );
		    DAT_ram_00a588a4 = '\x01';
		  }
		  Sirenix_Serialization_FormatterEmitter_AOTEmittedFormatter___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_Gameplay_Accounts_View_Banners_AbstractAccountBannerView_ManufactureAccount___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564C")]
		[Address(RVA = "0xA3DA", Offset = "0xA3DA", VA = "0xA3DA")]
		public ManufactureAccountBannerView()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AccountId ---
		undefined4
		Gameplay_Accounts_View_Banners_ManufactureAccountBannerView__get_AccountId
		          (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a588a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2480);
		    DAT_ram_00a588a3 = '\x01';
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
