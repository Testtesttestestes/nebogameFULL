using System;
using System.Collections.Generic;
using AssetContent;
using Gameplay.Discounts.Model;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Elements.Counters;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Buildings
{
	// Token: 0x0200024A RID: 586
	[Token(Token = "0x200024A")]
	public class SpellItem : SelectedGenericListElement<SpellItemArgs>, IDiscountTarget
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EC")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x60D7", Offset = "0x60D7", VA = "0x60D7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x00004200 File Offset: 0x00002400
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001ED")]
		public override bool Selected
		{
			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x60D8", Offset = "0x60D8", VA = "0x60D8", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x60D9", Offset = "0x60D9", VA = "0x60D9", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x60DA", Offset = "0x60DA", VA = "0x60DA", Slot = "4")]
		protected override void OnInit(SpellItemArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void UI_Elements_Buildings_SpellItem__OnInit(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a639af == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639af = '\x01';
		  }
		  func_ii_14558(*(undefined4 *)(param1 + 0x14),0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x60DB", Offset = "0x60DB", VA = "0x60DB")]
		public void Close()
		{
		/* --- GHIDRA: Close ---
		int UI_Elements_Buildings_SpellItem__Close(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a639b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_DiscountTargets___TypeInfo);
		    DAT_ram_00a639b0 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_DiscountTargets___TypeInfo,1);
		  *(undefined4 *)(iVar1 + 0x10) = 5;
		  return iVar1;
		}
		*/

		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EE")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x60DC", Offset = "0x60DC", VA = "0x60DC", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x60DD", Offset = "0x60DD", VA = "0x60DD", Slot = "10")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		/* --- GHIDRA: Setup ---
		void UI_Elements_Buildings_SpellItem__Setup(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_SelectedGenericListElement_SpellItemArgs___ctor__);
		    DAT_ram_00a639b2 = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListArgs_object____ctor
		            (param1,Method_UI_Elements_GenericList_SelectedGenericListElement_SpellItemArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x60DE", Offset = "0x60DE", VA = "0x60DE")]
		public SpellItem()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_Buildings_SpellItem___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined4 *)(param1 + 8) = 0xffffffff;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined1 *)(param1 + 0x18) = (undefined1)param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  return;
		}
		*/

		}

		// Token: 0x0400071E RID: 1822
		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameImage _spellGameImage;

		// Token: 0x0400071F RID: 1823
		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x04000720 RID: 1824
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x04000721 RID: 1825
		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ParticleSystem _learningEffect;

		// Token: 0x04000722 RID: 1826
		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _discountWidget;

		// Token: 0x04000723 RID: 1827
		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x34")]
		private IGuideTarget _guideTarget;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GuideTarget ---
		uint UI_Elements_Buildings_SpellItem__get_GuideTarget(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_SpellItemArgs__get_Selected__
		              );
		    DAT_ram_00a639ac = '\x01';
		  }
		  return (uint)*(byte *)(param1 + 0x1d);
		}
		*/


		/* --- GHIDRA: get_Selected ---
		void UI_Elements_Buildings_SpellItem__get_Selected(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a639ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_SpellItemArgs__set_Selected__
		              );
		    DAT_ram_00a639ad = '\x01';
		  }
		  *(char *)(param1 + 0x1d) = (char)param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void UI_Elements_Buildings_SpellItem__set_Selected(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  int *piVar4;
		  float param2_01;
		  int iVar5;
		  int iVar6;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a639ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    DAT_ram_00a639ae = '\x01';
		  }
		  param2_01 = 0.0;
		  if (*(int *)(param2 + 0x14) == 0) {
		    param2_01 = 1.0;
		  }
		  UI_ImageAnimation__ShowAnimation_d__9__System_Collections_IEnumerator_get_Current
		            (*(undefined4 *)(param1 + 0x20),param2_01,0);
		  AssetContent_GameImage__get_AssetId
		            (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param2 + 0x10),0);
		  local_4 = *(undefined4 *)(param2 + 0x14);
		  piVar4 = *(int **)(*(int *)(param1 + 0x28) + 0x10);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar5 + 0x2d4));
		  local_8 = *(undefined4 *)(param1 + 0x2c);
		  if (*(char *)(param2 + 0x18) == '\0') {
		    UnityEngine_ParticleSystem_MainModule__get_playOnAwake(&local_8,0,0);
		    UnityEngine_ParticleSystem__Stop(*(undefined4 *)(param1 + 0x2c),0);
		  }
		  else {
		    UnityEngine_ParticleSystem_MainModule__get_playOnAwake(&local_8,1,0);
		    UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x2c),0);
		  }
		  if (DAT_ram_00a639ab == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a639ab = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x34);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x10),
		                                 Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int **)(param1 + 0x34) = piVar4;
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x823250ea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4);
		code_r0x823250ea:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  if (DAT_ram_00a639ab == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a639ab = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x34);
		  if (piVar4 == (int *)0x0) {
		    piVar4 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x10),
		                                 Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int **)(param1 + 0x34) = piVar4;
		  uVar1 = 0;
		  iVar5 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,1);
		  *(ulonglong *)(iVar5 + 0x10) = (ulonglong)*(uint *)(param2 + 0xc);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		        goto code_r0x823251c6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5);
		code_r0x823251c6:
		  param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,iVar5,puVar3[1]);
		  UnityEngine_Object__op_Implicit(uVar2,param2_00,0);
		  piVar4 = *(int **)(param2 + 0x1c);
		  if (piVar4 != (int *)0x0) {
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x82325253;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x82325253:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar4,param1,puVar3[1]);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_DiscountTargets ---
		void UI_Elements_Buildings_SpellItem__get_DiscountTargets
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a639b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		    DAT_ram_00a639b1 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x30),0);
		  param2_00 = System_Linq_Enumerable__OrderBy_object__ulong_
		                        (param2,Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

}
