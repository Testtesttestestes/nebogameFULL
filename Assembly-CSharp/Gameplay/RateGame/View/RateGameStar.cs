using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.RateGame.View
{
	// Token: 0x020005A3 RID: 1443
	[Token(Token = "0x20005A3")]
	public class RateGameStar : MonoBehaviour
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00006D38 File Offset: 0x00004F38
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000651")]
		public int Id
		{
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x73F6", Offset = "0x73F6", VA = "0x73F6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022A0")]
			[Address(RVA = "0x73F7", Offset = "0x73F7", VA = "0x73F7")]
			set
			{
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00006D50 File Offset: 0x00004F50
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000652")]
		public bool StarEnabled
		{
			[Token(Token = "0x60022A1")]
			[Address(RVA = "0x73F8", Offset = "0x73F8", VA = "0x73F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022A2")]
			[Address(RVA = "0x73F9", Offset = "0x73F9", VA = "0x73F9")]
			set
			{
			}
		}

		// Token: 0x14000147 RID: 327
		// (add) Token: 0x060022A3 RID: 8867 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060022A4 RID: 8868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000147")]
		public event Action<int> RollOverEvent
		{
			[Token(Token = "0x60022A3")]
			[Address(RVA = "0x73FA", Offset = "0x73FA", VA = "0x73FA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022A4")]
			[Address(RVA = "0x73FB", Offset = "0x73FB", VA = "0x73FB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000148 RID: 328
		// (add) Token: 0x060022A5 RID: 8869 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060022A6 RID: 8870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000148")]
		public event Action<int> RollOutEvent
		{
			[Token(Token = "0x60022A5")]
			[Address(RVA = "0x73FC", Offset = "0x73FC", VA = "0x73FC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022A6")]
			[Address(RVA = "0x73FD", Offset = "0x73FD", VA = "0x73FD")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000149 RID: 329
		// (add) Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060022A8 RID: 8872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000149")]
		public event Action<int> ClickEvent
		{
			[Token(Token = "0x60022A7")]
			[Address(RVA = "0x73FE", Offset = "0x73FE", VA = "0x73FE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60022A8")]
			[Address(RVA = "0x73FF", Offset = "0x73FF", VA = "0x73FF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A9")]
		[Address(RVA = "0x7400", Offset = "0x7400", VA = "0x7400")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_RateGame_View_RateGameStar__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a580bb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RateGame_View_RateGameStar_BgOnOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_View_RateGameStar_BgOnOnPointerEnterEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_View_RateGameStar_BgOnOnPointerExitEvent__);
		    DAT_ram_00a580bb = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_RateGame_View_RateGameStar_BgOnOnClickEvent__,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_RateGame_View_RateGameStar_BgOnOnPointerEnterEvent__,0);
		  Utils_MonoPointerClickHandler__add_OnPointerEnterEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_RateGame_View_RateGameStar_BgOnOnPointerExitEvent__,0);
		  Utils_MonoPointerClickHandler__add_OnPointerExitEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AA")]
		[Address(RVA = "0x7401", Offset = "0x7401", VA = "0x7401")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_RateGame_View_RateGameStar__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AB")]
		[Address(RVA = "0x7402", Offset = "0x7402", VA = "0x7402")]
		private void BgOnOnPointerExitEvent(PointerEventData obj)
		{
		/* --- GHIDRA: BgOnOnPointerExitEvent ---
		void Gameplay_RateGame_View_RateGameStar__BgOnOnPointerExitEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x28);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AC")]
		[Address(RVA = "0x7403", Offset = "0x7403", VA = "0x7403")]
		private void BgOnOnPointerEnterEvent(PointerEventData obj)
		{
		/* --- GHIDRA: BgOnOnPointerEnterEvent ---
		void Gameplay_RateGame_View_RateGameStar__BgOnOnPointerEnterEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x7404", Offset = "0x7404", VA = "0x7404")]
		private void BgOnOnClickEvent(PointerEventData obj)
		{
		/* --- GHIDRA: BgOnOnClickEvent ---
		void Gameplay_RateGame_View_RateGameStar__BgOnOnClickEvent(int param1,undefined4 param2)
		
		{
		  UnityEngine_ParticleSystem__Stop(*(undefined4 *)(param1 + 0x18),0);
		  UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x18),0);
		  UnityEngine_ParticleSystem__Stop(*(undefined4 *)(param1 + 0x1c),0);
		  UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x7405", Offset = "0x7405", VA = "0x7405")]
		public void PlayFx()
		{
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x7406", Offset = "0x7406", VA = "0x7406")]
		private void UpdateFxStrength()
		{
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x7407", Offset = "0x7407", VA = "0x7407")]
		public RateGameStar()
		{
		}

		// Token: 0x040012E7 RID: 4839
		[Token(Token = "0x40012E7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _bg;

		// Token: 0x040012E8 RID: 4840
		[Token(Token = "0x40012E8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _star;

		// Token: 0x040012E9 RID: 4841
		[Token(Token = "0x40012E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _particleFx;

		// Token: 0x040012EA RID: 4842
		[Token(Token = "0x40012EA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ParticleSystem _particleFx2;

		// Token: 0x040012EB RID: 4843
		[Token(Token = "0x40012EB")]
		[FieldOffset(Offset = "0x20")]
		private int _id;

		// Token: 0x040012EC RID: 4844
		[Token(Token = "0x40012EC")]
		[FieldOffset(Offset = "0x24")]
		private bool _starEnabled;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StarEnabled ---
		void Gameplay_RateGame_View_RateGameStar__get_StarEnabled
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined1 *)(param1 + 0x24) = (undefined1)param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x24),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_StarEnabled ---
		void Gameplay_RateGame_View_RateGameStar__set_StarEnabled
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a580b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a580b4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: add_RollOverEvent ---
		void Gameplay_RateGame_View_RateGameStar__add_RollOverEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a580b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a580b5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: remove_RollOverEvent ---
		void Gameplay_RateGame_View_RateGameStar__remove_RollOverEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a580b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a580b6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: add_RollOutEvent ---
		void Gameplay_RateGame_View_RateGameStar__add_RollOutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a580b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a580b7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_RollOutEvent ---
		void Gameplay_RateGame_View_RateGameStar__remove_RollOutEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a580b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a580b8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_RateGame_View_RateGameStar__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a580b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a580b9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_RateGame_View_RateGameStar__remove_ClickEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a580ba == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RateGame_View_RateGameStar_BgOnOnClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_View_RateGameStar_BgOnOnPointerEnterEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_View_RateGameStar_BgOnOnPointerExitEvent__);
		    DAT_ram_00a580ba = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_RateGame_View_RateGameStar_BgOnOnClickEvent__,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_RateGame_View_RateGameStar_BgOnOnPointerEnterEvent__,0);
		  Utils_MonoPointerClickHandler__remove_OnPointerDownEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_RateGame_View_RateGameStar_BgOnOnPointerExitEvent__,0);
		  Utils_MonoPointerClickHandler__remove_OnPointerEnterEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
