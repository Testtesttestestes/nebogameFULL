using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	public class CultView2 : MonoBehaviour
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000424")]
		public CultDic CultDic
		{
			[Token(Token = "0x60017C4")]
			[Address(RVA = "0x697F", Offset = "0x697F", VA = "0x697F")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017C5")]
			[Address(RVA = "0x6980", Offset = "0x6980", VA = "0x6980")]
			set
			{
			}
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x6981", Offset = "0x6981", VA = "0x6981", Slot = "4")]
		protected virtual void HandleCultDicChanged()
		{
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x6982", Offset = "0x6982", VA = "0x6982")]
		public void SetIconAssetId(string assetId)
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x6983", Offset = "0x6983", VA = "0x6983")]
		public CultView2()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_CultView2___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a598d2 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		  if (iVar1 != 0) {
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x18),param2,0)
		    ;
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _image;

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x14")]
		private CultDic _cultDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CultDic ---
		void Gameplay_UserInfo_View_CultView2__get_CultDic(int *param1,int param2,undefined4 param3)
		
		{
		  if (param2 != param1[5]) {
		    param1[5] = param2;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CultDic ---
		void Gameplay_UserInfo_View_CultView2__set_CultDic(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  if (*(int *)(param1 + 0x14) != 0) {
		    param2_00 = Core_Extensions_Dict_CultDicExt__GetNickBarBgAssetId(*(int *)(param1 + 0x14),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		              (*(undefined4 *)(param1 + 0x10),param2_00,0);
		  }
		  return;
		}
		*/

}
