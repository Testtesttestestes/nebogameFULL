using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.RateGame.View
{
	// Token: 0x020005A1 RID: 1441
	[Token(Token = "0x20005A1")]
	public class RateGameComponent : MonoBehaviour
	{
		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x1700064E")]
		public int Value
		{
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x73E5", Offset = "0x73E5", VA = "0x73E5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600228F")]
		[Address(RVA = "0x73E6", Offset = "0x73E6", VA = "0x73E6")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		int Gameplay_RateGame_View_RateGameComponent__Awake(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a580b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_RateGame_View_RateGameComponent__DemoCoroutine_d__6_TypeInfo);
		    DAT_ram_00a580b1 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_RateGame_View_RateGameComponent__DemoCoroutine_d__6_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002290")]
		[Address(RVA = "0x73E7", Offset = "0x73E7", VA = "0x73E7")]
		private IEnumerator DemoCoroutine()
		{
		/* --- GHIDRA: DemoCoroutine ---
		void Gameplay_RateGame_View_RateGameComponent__DemoCoroutine(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x18),0);
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002291")]
		[Address(RVA = "0x73E8", Offset = "0x73E8", VA = "0x73E8")]
		private void StopDemoCoroutine()
		{
		/* --- GHIDRA: StopDemoCoroutine ---
		void Gameplay_RateGame_View_RateGameComponent__StopDemoCoroutine(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a580b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RateGame_View_RateGameComponent_SOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RateGame_View_RateGameComponent_SOnRollOutEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_View_RateGameComponent_SOnRollOverEvent__);
		    DAT_ram_00a580b2 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar7 + 0xc)) {
		    do {
		      iVar7 = *(int *)(iVar7 + iVar8 * 4 + 0x10);
		      uVar5 = unnamed_function_1417(System_Action_int__TypeInfo);
		      System_Action_short___Invoke
		                (uVar5,param1,Method_Gameplay_RateGame_View_RateGameComponent_SOnRollOverEvent__,0);
		      if (DAT_ram_00a580b5 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		        DAT_ram_00a580b5 = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 0x28);
		      do {
		        iVar4 = 0;
		        iVar6 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_int__TypeInfo;
		        if ((iVar6 != 0) && (iVar4 = func_ii_1082(iVar6,System_Action_int__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(iVar7 + 0x28,iVar4,iVar3);
		        bVar1 = iVar4 != iVar3;
		        iVar3 = iVar4;
		      } while (bVar1);
		      uVar5 = unnamed_function_1417(System_Action_int__TypeInfo);
		      System_Action_short___Invoke
		                (uVar5,param1,Method_Gameplay_RateGame_View_RateGameComponent_SOnRollOutEvent__,0);
		      if (DAT_ram_00a580b7 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		        DAT_ram_00a580b7 = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 0x2c);
		      do {
		        iVar4 = 0;
		        iVar6 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_int__TypeInfo;
		        if ((iVar6 != 0) && (iVar4 = func_ii_1082(iVar6,System_Action_int__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(iVar7 + 0x2c,iVar4,iVar3);
		        bVar1 = iVar4 != iVar3;
		        iVar3 = iVar4;
		      } while (bVar1);
		      uVar5 = unnamed_function_1417(System_Action_int__TypeInfo);
		      System_Action_short___Invoke
		                (uVar5,param1,Method_Gameplay_RateGame_View_RateGameComponent_SOnClickEvent__,0);
		      if (DAT_ram_00a580b9 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		        DAT_ram_00a580b9 = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 0x30);
		      do {
		        iVar4 = 0;
		        iVar6 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_int__TypeInfo;
		        if ((iVar6 != 0) && (iVar4 = func_ii_1082(iVar6,System_Action_int__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(iVar7 + 0x30,iVar4,iVar3);
		        bVar1 = iVar4 != iVar3;
		        iVar3 = iVar4;
		      } while (bVar1);
		      iVar8 = iVar8 + 1;
		      iVar7 = *(int *)(param1 + 0x10);
		    } while (iVar8 < *(int *)(iVar7 + 0xc));
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x18),0);
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002292")]
		[Address(RVA = "0x73E9", Offset = "0x73E9", VA = "0x73E9")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_RateGame_View_RateGameComponent__OnDestroy(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x18),0);
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  *(int *)(param1 + 0x14) = param2;
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      *(bool *)(iVar2 + 0x24) = *(int *)(iVar2 + 0x20) <= param2;
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,(uint)*(byte *)(iVar2 + 0x24),0);
		      iVar1 = iVar1 + 1;
		      iVar2 = *(int *)(param1 + 0x10);
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  if (0 < param2) {
		    iVar1 = 0;
		    do {
		      iVar2 = *(int *)(*(int *)(param1 + 0x10) + iVar1 * 4 + 0x10);
		      UnityEngine_ParticleSystem__Stop(*(undefined4 *)(iVar2 + 0x18),0);
		      UnityEngine_ParticleSystem__Play(*(undefined4 *)(iVar2 + 0x18),0);
		      UnityEngine_ParticleSystem__Stop(*(undefined4 *)(iVar2 + 0x1c),0);
		      UnityEngine_ParticleSystem__Play(*(undefined4 *)(iVar2 + 0x1c),0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != param2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002293")]
		[Address(RVA = "0x73EA", Offset = "0x73EA", VA = "0x73EA")]
		private void SOnClickEvent(int index)
		{
		/* --- GHIDRA: SOnClickEvent ---
		void Gameplay_RateGame_View_RateGameComponent__SOnClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x18),0);
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  iVar2 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar3 = *(int *)(param1 + 0x14);
		    iVar1 = 0;
		    do {
		      iVar2 = *(int *)(iVar2 + iVar1 * 4 + 0x10);
		      *(bool *)(iVar2 + 0x24) = *(int *)(iVar2 + 0x20) <= iVar3;
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,(uint)*(byte *)(iVar2 + 0x24),0);
		      iVar1 = iVar1 + 1;
		      iVar2 = *(int *)(param1 + 0x10);
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002294")]
		[Address(RVA = "0x73EB", Offset = "0x73EB", VA = "0x73EB")]
		private void SOnRollOutEvent(int index)
		{
		/* --- GHIDRA: SOnRollOutEvent ---
		void Gameplay_RateGame_View_RateGameComponent__SOnRollOutEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = 0;
		  if (*(int *)(param1 + 0x18) != 0) {
		    func_ii_20511(param1,*(int *)(param1 + 0x18),0);
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = *(int *)(iVar1 + iVar2 * 4 + 0x10);
		      *(bool *)(iVar1 + 0x24) = *(int *)(iVar1 + 0x20) <= param2;
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar1 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,(uint)*(byte *)(iVar1 + 0x24),0);
		      iVar2 = iVar2 + 1;
		      iVar1 = *(int *)(param1 + 0x10);
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002295")]
		[Address(RVA = "0x73EC", Offset = "0x73EC", VA = "0x73EC")]
		private void SOnRollOverEvent(int index)
		{
		/* --- GHIDRA: SOnRollOverEvent ---
		void Gameplay_RateGame_View_RateGameComponent__SOnRollOverEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = 0;
		  iVar1 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = *(int *)(iVar1 + iVar2 * 4 + 0x10);
		      *(bool *)(iVar1 + 0x24) = *(int *)(iVar1 + 0x20) <= param2;
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar1 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,(uint)*(byte *)(iVar1 + 0x24),0);
		      iVar2 = iVar2 + 1;
		      iVar1 = *(int *)(param1 + 0x10);
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002296")]
		[Address(RVA = "0x73ED", Offset = "0x73ED", VA = "0x73ED")]
		private void HighlightValue(int value)
		{
		/* --- GHIDRA: HighlightValue ---
		void Gameplay_RateGame_View_RateGameComponent__HighlightValue
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = 0;
		  *(int *)(param1 + 0x14) = param2;
		  iVar1 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = *(int *)(iVar1 + iVar2 * 4 + 0x10);
		      *(bool *)(iVar1 + 0x24) = *(int *)(iVar1 + 0x20) <= param2;
		      param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar1 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,(uint)*(byte *)(iVar1 + 0x24),0);
		      iVar2 = iVar2 + 1;
		      iVar1 = *(int *)(param1 + 0x10);
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002297")]
		[Address(RVA = "0x73EE", Offset = "0x73EE", VA = "0x73EE")]
		private void SetValue(int value)
		{
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x73EF", Offset = "0x73EF", VA = "0x73EF")]
		public RateGameComponent()
		{
		}

		// Token: 0x040012E0 RID: 4832
		[Token(Token = "0x40012E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RateGameStar[] _stars;

		// Token: 0x040012E1 RID: 4833
		[Token(Token = "0x40012E1")]
		[FieldOffset(Offset = "0x14")]
		private int _value;

		// Token: 0x040012E2 RID: 4834
		[Token(Token = "0x40012E2")]
		[FieldOffset(Offset = "0x18")]
		private Coroutine _demoCoroutine;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		void Gameplay_RateGame_View_RateGameComponent__get_Value(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a580b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RateGame_View_RateGameComponent_SOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RateGame_View_RateGameComponent_SOnRollOutEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RateGame_View_RateGameComponent_SOnRollOverEvent__);
		    DAT_ram_00a580b0 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x10);
		  if (*(int *)(iVar7 + 0xc) < 1) {
		    *(undefined4 *)(param1 + 0x14) = 0;
		  }
		  else {
		    do {
		      iVar7 = *(int *)(iVar7 + iVar3 * 4 + 0x10);
		      iVar3 = iVar3 + 1;
		      *(int *)(iVar7 + 0x20) = iVar3;
		      uVar6 = unnamed_function_1417(System_Action_int__TypeInfo);
		      System_Action_short___Invoke
		                (uVar6,param1,Method_Gameplay_RateGame_View_RateGameComponent_SOnRollOverEvent__,0);
		      if (DAT_ram_00a580b4 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		        DAT_ram_00a580b4 = '\x01';
		      }
		      iVar8 = *(int *)(iVar7 + 0x28);
		      do {
		        iVar4 = 0;
		        iVar5 = UnityEngine_UI_Image__set_sprite(iVar8,uVar6,0);
		        uVar2 = System_Action_int__TypeInfo;
		        if ((iVar5 != 0) && (iVar4 = func_ii_1082(iVar5,System_Action_int__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(iVar5,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(iVar7 + 0x28,iVar4,iVar8);
		        bVar1 = iVar4 != iVar8;
		        iVar8 = iVar4;
		      } while (bVar1);
		      uVar6 = unnamed_function_1417(System_Action_int__TypeInfo);
		      System_Action_short___Invoke
		                (uVar6,param1,Method_Gameplay_RateGame_View_RateGameComponent_SOnRollOutEvent__,0);
		      if (DAT_ram_00a580b6 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		        DAT_ram_00a580b6 = '\x01';
		      }
		      iVar8 = *(int *)(iVar7 + 0x2c);
		      do {
		        iVar4 = 0;
		        iVar5 = UnityEngine_UI_Image__set_sprite(iVar8,uVar6,0);
		        uVar2 = System_Action_int__TypeInfo;
		        if ((iVar5 != 0) && (iVar4 = func_ii_1082(iVar5,System_Action_int__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(iVar5,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(iVar7 + 0x2c,iVar4,iVar8);
		        bVar1 = iVar4 != iVar8;
		        iVar8 = iVar4;
		      } while (bVar1);
		      uVar6 = unnamed_function_1417(System_Action_int__TypeInfo);
		      System_Action_short___Invoke
		                (uVar6,param1,Method_Gameplay_RateGame_View_RateGameComponent_SOnClickEvent__,0);
		      if (DAT_ram_00a580b8 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		        DAT_ram_00a580b8 = '\x01';
		      }
		      iVar8 = *(int *)(iVar7 + 0x30);
		      do {
		        iVar4 = 0;
		        iVar5 = UnityEngine_UI_Image__set_sprite(iVar8,uVar6,0);
		        uVar2 = System_Action_int__TypeInfo;
		        if ((iVar5 != 0) && (iVar4 = func_ii_1082(iVar5,System_Action_int__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(iVar5,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(iVar7 + 0x30,iVar4,iVar8);
		        bVar1 = iVar4 != iVar8;
		        iVar8 = iVar4;
		      } while (bVar1);
		      iVar7 = *(int *)(param1 + 0x10);
		      iVar8 = *(int *)(iVar7 + 0xc);
		    } while (iVar3 < iVar8);
		    iVar3 = 0;
		    *(undefined4 *)(param1 + 0x14) = 0;
		    if (0 < iVar8) {
		      do {
		        iVar7 = *(int *)(iVar7 + iVar3 * 4 + 0x10);
		        *(bool *)(iVar7 + 0x24) = *(int *)(iVar7 + 0x20) < 1;
		        uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar7 + 0x14),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar6,(uint)*(byte *)(iVar7 + 0x24),0);
		        iVar3 = iVar3 + 1;
		        iVar7 = *(int *)(param1 + 0x10);
		      } while (iVar3 < *(int *)(iVar7 + 0xc));
		    }
		  }
		  if (DAT_ram_00a580b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_RateGame_View_RateGameComponent__DemoCoroutine_d__6_TypeInfo);
		    DAT_ram_00a580b1 = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (Gameplay_RateGame_View_RateGameComponent__DemoCoroutine_d__6_TypeInfo);
		  *(int *)(iVar3 + 0x10) = param1;
		  *(undefined4 *)(iVar3 + 8) = 0;
		  uVar6 = UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar3,0);
		  *(undefined4 *)(param1 + 0x18) = uVar6;
		  return;
		}
		*/

}
