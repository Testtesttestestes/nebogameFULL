using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B85 RID: 2949
	[Token(Token = "0x2000B85")]
	public class BossUserListItemView : MonoBehaviour
	{
		// Token: 0x140001C7 RID: 455
		// (add) Token: 0x060047AD RID: 18349 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060047AE RID: 18350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C7")]
		public event Action<UserData> ClickedEvent
		{
			[Token(Token = "0x60047AD")]
			[Address(RVA = "0x9639", Offset = "0x9639", VA = "0x9639")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60047AE")]
			[Address(RVA = "0x963A", Offset = "0x963A", VA = "0x963A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AF")]
		[Address(RVA = "0x963B", Offset = "0x963B", VA = "0x963B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_CaptainTab_BossUserListItemView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a6e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossUserListItemView_ClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a6e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossUserListItemView_ClickHandlerOnOnClickEvent__,
		             0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B0")]
		[Address(RVA = "0x963C", Offset = "0x963C", VA = "0x963C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Boss_View_CaptainTab_BossUserListItemView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x28),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B1")]
		[Address(RVA = "0x963D", Offset = "0x963D", VA = "0x963D")]
		private void ClickHandlerOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x060047B2 RID: 18354 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047B3 RID: 18355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E56")]
		public UserData UserData
		{
			[Token(Token = "0x60047B2")]
			[Address(RVA = "0x963E", Offset = "0x963E", VA = "0x963E")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047B3")]
			[Address(RVA = "0x963F", Offset = "0x963F", VA = "0x963F")]
			set
			{
			}
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B4")]
		[Address(RVA = "0x9640", Offset = "0x9640", VA = "0x9640")]
		public BossUserListItemView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Boss_View_CaptainTab_BossUserListItemView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57a6f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SimpleIconValue___);
		    DAT_ram_00a57a6f = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    return *(undefined4 *)(param1 + 0x10);
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SimpleIconValue___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return uVar1;
		}
		*/

		}

		// Token: 0x04002763 RID: 10083
		[Token(Token = "0x4002763")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x04002764 RID: 10084
		[Token(Token = "0x4002764")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04002765 RID: 10085
		[Token(Token = "0x4002765")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04002766 RID: 10086
		[Token(Token = "0x4002766")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameRawImage _cultIcon;

		// Token: 0x04002767 RID: 10087
		[Token(Token = "0x4002767")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x04002769 RID: 10089
		[Token(Token = "0x4002769")]
		[FieldOffset(Offset = "0x28")]
		private UserData _userData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickedEvent ---
		void Gameplay_Boss_View_CaptainTab_BossUserListItemView__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a6c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a57a6c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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
		void Gameplay_Boss_View_CaptainTab_BossUserListItemView__remove_ClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a6d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_CaptainTab_BossUserListItemView_ClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a6d = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_CaptainTab_BossUserListItemView_ClickHandlerOnOnClickEvent__,
		             0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_UserData ---
		void Gameplay_Boss_View_CaptainTab_BossUserListItemView__get_UserData
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  *(int *)(param1 + 0x28) = param2;
		  if (param2 != 0) {
		    piVar2 = *(int **)(param1 + 0x14);
		    uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param2,0);
		    iVar4 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar4 + 0x2d4));
		    uVar3 = *(undefined4 *)(param1 + 0x1c);
		    uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                      (*(undefined4 *)(*(int *)(param1 + 0x28) + 0x4c),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar3,uVar1,0);
		    Gameplay_Rating_View_UserView__get_UserData
		              (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x28),0);
		    uVar3 = *(undefined4 *)(param1 + 0x20);
		    uVar1 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0x28),0);
		    UI_Elements_Counters_CounterAutoHide___ctor(uVar3,uVar1,0);
		  }
		  return;
		}
		*/

}
