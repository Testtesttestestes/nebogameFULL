using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000953 RID: 2387
	[Token(Token = "0x2000953")]
	public class SkillsInfoVisibilityHandler : MonoBehaviour
	{
		// Token: 0x1400017F RID: 383
		// (add) Token: 0x0600388E RID: 14478 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600388F RID: 14479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017F")]
		public event Action<bool> SkillVisibleChangedEvent
		{
			[Token(Token = "0x600388E")]
			[Address(RVA = "0x8838", Offset = "0x8838", VA = "0x8838")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600388F")]
			[Address(RVA = "0x8839", Offset = "0x8839", VA = "0x8839")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B26")]
		public SkillsInfo[] SkillsInfo
		{
			[Token(Token = "0x6003890")]
			[Address(RVA = "0x883A", Offset = "0x883A", VA = "0x883A")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003891")]
		[Address(RVA = "0x883B", Offset = "0x883B", VA = "0x883B")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5670d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler_CloseAll__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5670d = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_01 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 0x20) + 0xb4);
		      param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (param1_00,param1,
		                 Method_Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler_CloseAll__,0);
		      UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003892")]
		[Address(RVA = "0x883C", Offset = "0x883C", VA = "0x883C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar2 = *(int *)(param1 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003893 RID: 14483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x883D", Offset = "0x883D", VA = "0x883D")]
		public void OpenAll()
		{
		/* --- GHIDRA: OpenAll ---
		void Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler__OpenAll(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,0,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  iVar2 = *(int *)(param1 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),0,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x883E", Offset = "0x883E", VA = "0x883E")]
		public void CloseAll()
		{
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003895")]
		[Address(RVA = "0x883F", Offset = "0x883F", VA = "0x883F")]
		public SkillsInfoVisibilityHandler()
		{
		}

		// Token: 0x04001F48 RID: 8008
		[Token(Token = "0x4001F48")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SkillsInfo[] _skillsInfo;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SkillVisibleChangedEvent ---
		void Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler__add_SkillVisibleChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5670b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a5670b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: get_SkillsInfo ---
		void Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler__get_SkillsInfo
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5670c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler_CloseAll__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5670c = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_01 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + iVar1 * 4 + 0x10) + 0x20) + 0xb4);
		      param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (param1_00,param1,
		                 Method_Gameplay_Combat_View_Players_SkillsInfoVisibilityHandler_CloseAll__,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

}
