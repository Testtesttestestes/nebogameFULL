using System;
using Core.Data;
using Core.Data.Balance;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Common;
using TMPro;
using UI.Elements.GenericList;
using UI.Price;
using UnityEngine;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	public class TreasuryOptionListElement : SelectableListElement<TreasuryOptionListElement.TreasuryOptionListElementArgs>
	{
		// Token: 0x06001285 RID: 4741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x647F", Offset = "0x647F", VA = "0x647F", Slot = "7")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement__Awake
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58bd4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_TreasuryOptionListElement_TreasuryOptionListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17775);
		    DAT_ram_00a58bd4 = '\x01';
		  }
		  iVar4 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		            (*(int **)(param1 + 0x24),*(undefined4 *)(*(int *)(param1 + 0x18) + 0x20),
		             *(undefined4 *)(iVar4 + 0x13c));
		  uVar1 = *(undefined4 *)(param1 + 0x28);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x24);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x28);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		  UI_Price_Price__SetColor(uVar1,uVar3,uVar2,0);
		  uVar1 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17775,1,0,1,0,0,0,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x1c);
		  uVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_21978,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar4 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x6480", Offset = "0x6480", VA = "0x6480", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x6481", Offset = "0x6481", VA = "0x6481", Slot = "10")]
		protected override void CallElementClickedEvent(TreasuryOptionListElement.TreasuryOptionListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_WorldAxis_ColossusInfo_View_TreasuryOptionListElement__CallElementClickedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58bd5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_TreasuryOptionListElement_TreasuryOptionListElementArgs___ctor__
		              );
		    DAT_ram_00a58bd5 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_TreasuryOptionListElement_TreasuryOptionListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x6482", Offset = "0x6482", VA = "0x6482")]
		public TreasuryOptionListElement()
		{
		}

		// Token: 0x04000A03 RID: 2563
		[Token(Token = "0x4000A03")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04000A04 RID: 2564
		[Token(Token = "0x4000A04")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Price _price;

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _availableText;

		// Token: 0x02000326 RID: 806
		[Token(Token = "0x2000326")]
		public class TreasuryOptionListElementArgs : SelectableListElementArgs<TreasuryOptionListElement>
		{
			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06001289 RID: 4745 RVA: 0x00004980 File Offset: 0x00002B80
			// (set) Token: 0x0600128A RID: 4746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002DF")]
			public uint Count
			{
				[Token(Token = "0x6001289")]
				[Address(RVA = "0x6483", Offset = "0x6483", VA = "0x6483")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x600128A")]
				[Address(RVA = "0x6484", Offset = "0x6484", VA = "0x6484")]
				set
				{
				}
			}

			// Token: 0x0600128B RID: 4747 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600128B")]
			[Address(RVA = "0x6485", Offset = "0x6485", VA = "0x6485")]
			public TreasuryOptionListElementArgs()
			{
			}

			// Token: 0x04000A06 RID: 2566
			[Token(Token = "0x4000A06")]
			[FieldOffset(Offset = "0x1C")]
			private uint _count;

			// Token: 0x04000A07 RID: 2567
			[Token(Token = "0x4000A07")]
			[FieldOffset(Offset = "0x20")]
			public ArtifactData ArtifactData;

			// Token: 0x04000A08 RID: 2568
			[Token(Token = "0x4000A08")]
			[FieldOffset(Offset = "0x24")]
			public ResourceSet Price;

			// Token: 0x04000A09 RID: 2569
			[Token(Token = "0x4000A09")]
			[FieldOffset(Offset = "0x28")]
			public IBalanceSource ClanBalance;

			// Token: 0x04000A0A RID: 2570
			[Token(Token = "0x4000A0A")]
			[FieldOffset(Offset = "0x2C")]
			public uint OptionId;
		}
	}
}
