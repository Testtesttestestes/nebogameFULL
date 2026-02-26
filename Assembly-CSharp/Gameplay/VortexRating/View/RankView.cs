using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.VortexRating.View
{
	// Token: 0x02000383 RID: 899
	[Token(Token = "0x2000383")]
	public class RankView : MonoBehaviour
	{
		// Token: 0x060014F5 RID: 5365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x66B7", Offset = "0x66B7", VA = "0x66B7")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_VortexRating_View_RankView__Awake(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  int local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a581a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a581a3 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80eb1cbc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eb1cbc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetEventTagDic(uVar3,7 - param2,0);
		  uVar3 = Core_Extensions_Dict_ClanWarResultDicExt__GetBannerAssetId(uVar3,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar4,uVar3,0);
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar4 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar4,0);
		  return;
		}
		*/

		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x66B8", Offset = "0x66B8", VA = "0x66B8")]
		public void SetPlace(uint place)
		{
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x66B9", Offset = "0x66B9", VA = "0x66B9")]
		public RankView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_VortexRating_View_RankView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a581a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12684);
		    DAT_ram_00a581a4 = '\x01';
		  }
		  return StringLiteral_12684;
		}
		*/

		}

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		private const uint MAX_RANK = 6U;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private uint _place;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _rankImage;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _label;
	}
}
