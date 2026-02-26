using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F5 RID: 1013
	[Token(Token = "0x20003F5")]
	public class CultWhitBackground : CultView
	{
		// Token: 0x060017C9 RID: 6089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x6984", Offset = "0x6984", VA = "0x6984")]
		public void SetBackgroundAssetId(string assetId)
		{
		/* --- GHIDRA: SetBackgroundAssetId ---
		void Gameplay_UserInfo_View_CultWhitBackground__SetBackgroundAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (*(int *)(param1 + 0x14) != 0) {
		    uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                      (*(int *)(param1 + 0x14),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x10),uVar1,0);
		    if (*(int *)(param1 + 0x14) != 0) {
		      uVar1 = Core_Extensions_Dict_CrystalEnergyOptionsDicExt__GetEventPromoDescription
		                        (*(int *)(param1 + 0x14),0);
		      if (DAT_ram_00a598d2 == '\0') {
		        Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		        DAT_ram_00a598d2 = '\x01';
		      }
		      param1_00 = *(undefined4 *)(param1 + 0x18);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param1_00,0,0);
		      if (iVar2 != 0) {
		        Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		                  (*(undefined4 *)(param1 + 0x18),uVar1,0);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CA")]
		[Address(RVA = "0x6985", Offset = "0x6985", VA = "0x6985", Slot = "4")]
		protected override void HandleCultDicChanged()
		{
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x6986", Offset = "0x6986", VA = "0x6986")]
		public CultWhitBackground()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_UserInfo_View_CultWhitBackground___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a598d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12680);
		    DAT_ram_00a598d3 = '\x01';
		  }
		  return StringLiteral_12680;
		}
		*/

		}

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImage _background;
	}
}
