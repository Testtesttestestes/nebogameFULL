using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Clans.Office.View.ClanCreationTab
{
	// Token: 0x02000A3F RID: 2623
	[Token(Token = "0x2000A3F")]
	public class ClanTypeListElement : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000199 RID: 409
		// (add) Token: 0x06003E16 RID: 15894 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003E17 RID: 15895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000199")]
		public event Action<ClanTypeListElement> ClickedEvent
		{
			[Token(Token = "0x6003E16")]
			[Address(RVA = "0x8CD5", Offset = "0x8CD5", VA = "0x8CD5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003E17")]
			[Address(RVA = "0x8CD6", Offset = "0x8CD6", VA = "0x8CD6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (set) Token: 0x06003E18 RID: 15896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C70")]
		public bool Selected
		{
			[Token(Token = "0x6003E18")]
			[Address(RVA = "0x8CD7", Offset = "0x8CD7", VA = "0x8CD7")]
			set
			{
			}
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E19")]
		[Address(RVA = "0x8CD8", Offset = "0x8CD8", VA = "0x8CD8")]
		public void Init(CultDic dic)
		{
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1A")]
		[Address(RVA = "0x8CD9", Offset = "0x8CD9", VA = "0x8CD9", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E1B")]
		[Address(RVA = "0x8CDA", Offset = "0x8CDA", VA = "0x8CDA")]
		public ClanTypeListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57f86 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CultDic__get_Item__);
		    DAT_ram_00a57f86 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Core_Extensions_Dict_ClanCultDicExt__GetTitleBarBgAssetId(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Core_Extensions_Dict_ClanBuildingViewDicExt__GetIsleViewAssetId(param2,0);
		  AssetContent_GameImage__get_AssetId(uVar2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x20);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar2 = *(undefined4 *)(iVar3 + param2_00 * 4 + 0x10);
		      uVar1 = System_Linq_Enumerable__ToList_object_
		                        (param3,param2_00,Method_System_Collections_Generic_List_CultDic__get_Item__
		                        );
		      uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(uVar1,0);
		      AssetContent_GameImage__get_AssetId(uVar2,uVar1,0);
		      param2_00 = param2_00 + 1;
		      iVar3 = *(int *)(param1 + 0x20);
		    } while (param2_00 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x040022DE RID: 8926
		[Token(Token = "0x40022DE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _clanCultName;

		// Token: 0x040022DF RID: 8927
		[Token(Token = "0x40022DF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected GameImage _clanCultImage;

		// Token: 0x040022E0 RID: 8928
		[Token(Token = "0x40022E0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectedImage;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickedEvent ---
		void Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f85 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ClanTypeListElement__TypeInfo);
		    DAT_ram_00a57f85 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ClanTypeListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ClanTypeListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickedEvent ---
		void Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement__remove_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x18),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_Clans_Office_View_ClanCreationTab_ClanTypeListElement__set_Selected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  param2_00 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription(param2,0)
		  ;
		  AssetContent_GameImage__get_AssetId(param1_00,param2_00,0);
		  return;
		}
		*/

}
