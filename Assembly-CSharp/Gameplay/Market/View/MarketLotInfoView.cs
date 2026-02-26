using System;
using AssetContent;
using Core.Data;
using Gameplay.Inventory.View;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Market.View
{
	// Token: 0x0200061B RID: 1563
	[Token(Token = "0x200061B")]
	public class MarketLotInfoView : MonoBehaviour
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700071F")]
		public Button BuyButton
		{
			[Token(Token = "0x60025ED")]
			[Address(RVA = "0x772B", Offset = "0x772B", VA = "0x772B")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x772C", Offset = "0x772C", VA = "0x772C")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Market_View_MarketLotInfoView__Init
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59fe5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    DAT_ram_00a59fe5 = '\x01';
		  }
		  local_4 = 0;
		  iVar4 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		            (*(int **)(param1 + 0x10),param2[2],*(undefined4 *)(iVar4 + 0x13c));
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = Core_Data_ArtikulData__get_IsSellable(param2[2],0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  Gameplay_Market_View_MarketLotListElement_MarketLotListElementArgs__set_Selected
		            (*(undefined4 *)(param1 + 0x1c),param2,param3,param1);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		                    (param2,&local_4,*(undefined4 *)(*param2 + 0xfc));
		  uVar1 = *(undefined4 *)(param1 + 0x30);
		  if (iVar4 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3708,1,0,1,0,0,0,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    puVar3 = (undefined4 *)(param1 + 0x24);
		  }
		  else {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    puVar3 = (undefined4 *)(param1 + 0x20);
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x28),*puVar3,0);
		  AssetContent_GameImage__get_AssetId(*(undefined4 *)(param1 + 0x2c),param2[4],0);
		  return;
		}
		*/

		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x772D", Offset = "0x772D", VA = "0x772D")]
		public void UpdateView(MarketLotData data, UserData user)
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x772E", Offset = "0x772E", VA = "0x772E")]
		public MarketLotInfoView()
		{
		}

		// Token: 0x040014AC RID: 5292
		[Token(Token = "0x40014AC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x040014AD RID: 5293
		[Token(Token = "0x40014AD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ButtonWithCost _buyButton;

		// Token: 0x040014AE RID: 5294
		[Token(Token = "0x40014AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040014AF RID: 5295
		[Token(Token = "0x40014AF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MarketLotPriceView _priceView;

		// Token: 0x040014B0 RID: 5296
		[Token(Token = "0x40014B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _greenSprite;

		// Token: 0x040014B1 RID: 5297
		[Token(Token = "0x40014B1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _blueSprite;

		// Token: 0x040014B2 RID: 5298
		[Token(Token = "0x40014B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _buttonBg;

		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40014B3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameImage _ribbon;

		// Token: 0x040014B4 RID: 5300
		[Token(Token = "0x40014B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _buttonText;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BuyButton ---
		void Gameplay_Market_View_MarketLotInfoView__get_BuyButton(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a59fe4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    DAT_ram_00a59fe4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,2);
		  *(undefined8 *)(iVar1 + 0x10) = 0x1e00000005;
		  *(undefined4 *)(param1_00 + 0x58) = 0;
		  *(int *)(param1_00 + 0x54) = iVar1;
		  *(undefined4 *)(param1_00 + 0x50) = 0;
		  *(undefined1 *)(param1_00 + 0x45) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1_00,0);
		  return;
		}
		*/

}
