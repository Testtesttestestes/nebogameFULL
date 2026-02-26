using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000948 RID: 2376
	[Token(Token = "0x2000948")]
	public class CombatPlayerLevelView : MonoBehaviour
	{
		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x0000B3B8 File Offset: 0x000095B8
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B14")]
		public bool IsPremiumExp
		{
			[Token(Token = "0x6003833")]
			[Address(RVA = "0x87EA", Offset = "0x87EA", VA = "0x87EA")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003834")]
			[Address(RVA = "0x87EB", Offset = "0x87EB", VA = "0x87EB")]
			set
			{
			}
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003835")]
		[Address(RVA = "0x87EC", Offset = "0x87EC", VA = "0x87EC")]
		private void HandleIsPreminumExpChanged(bool from, bool to)
		{
		/* --- GHIDRA: HandleIsPreminumExpChanged ---
		void Gameplay_Combat_View_Players_CombatPlayerLevelView__HandleIsPreminumExpChanged
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  int local_4;
		  
		  local_4 = param2;
		  if (DAT_ram_00a566f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a566f3 = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		  if (param2 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,0,0);
		  }
		  else {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,1,0);
		    piVar2 = *(int **)(param1 + 0x18);
		    iVar1 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    if (iVar1 == 0) {
		      iVar1 = StringLiteral_5;
		    }
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,iVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003836")]
		[Address(RVA = "0x87ED", Offset = "0x87ED", VA = "0x87ED")]
		public void SetValue(uint value)
		{
		/* --- GHIDRA: SetValue ---
		void Gameplay_Combat_View_Players_CombatPlayerLevelView__SetValue
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a566f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RankImages__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RankImages__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_RankImages__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_RankImages__GetEnumerator__);
		    DAT_ram_00a566f4 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_List_RankImages__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_RankImages__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c6a628;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    iVar2 = local_8._4_4_;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                       *(undefined4 *)(local_8._4_4_ + 0xc),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar3,
		               (uint)(*(int *)(iVar2 + 8) == param2),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80c6a628:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x20c,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80c6a628;
		}
		*/

		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x87EE", Offset = "0x87EE", VA = "0x87EE")]
		public void SetRank(RankTypes value)
		{
		/* --- GHIDRA: SetRank ---
		void Gameplay_Combat_View_Players_CombatPlayerLevelView__SetRank
		               (int param1,float param2,undefined4 param3)
		
		{
		  UnityEngine_UI_Image__get_fillAmount(*(undefined4 *)(param1 + 0x20),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x87EF", Offset = "0x87EF", VA = "0x87EF")]
		public void SetExperienceProgress(float value)
		{
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x87F0", Offset = "0x87F0", VA = "0x87F0")]
		public CombatPlayerLevelView()
		{
		}

		// Token: 0x04001F13 RID: 7955
		[Token(Token = "0x4001F13")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Color32 _premiumExpColor;

		// Token: 0x04001F14 RID: 7956
		[Token(Token = "0x4001F14")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Color32 _expColor;

		// Token: 0x04001F15 RID: 7957
		[Token(Token = "0x4001F15")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _valueField;

		// Token: 0x04001F16 RID: 7958
		[Token(Token = "0x4001F16")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private List<RankImages> _rankImages;

		// Token: 0x04001F17 RID: 7959
		[Token(Token = "0x4001F17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _expIndicator;

		// Token: 0x04001F18 RID: 7960
		[Token(Token = "0x4001F18")]
		[FieldOffset(Offset = "0x24")]
		private bool _isPremiumExp;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsPremiumExp ---
		void Gameplay_Combat_View_Players_CombatPlayerLevelView__get_IsPremiumExp
		               (int param1,uint param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (param2 != *(byte *)(param1 + 0x24)) {
		    *(char *)(param1 + 0x24) = (char)param2;
		    iVar2 = 0x10;
		    if (param2 == 0) {
		      iVar2 = 0x14;
		    }
		    uVar1 = *(uint *)(param1 + iVar2);
		    local_8 = (float4)((float)(uVar1 >> 0x10 & 0xff) / 255.0);
		    local_4 = (float4)((float)(uVar1 >> 0x18) / 255.0);
		    local_10 = (float4)((float)(uVar1 & 0xff) / 255.0);
		    local_c = (float4)((float)(uVar1 >> 8 & 0xff) / 255.0);
		    iVar2 = **(int **)(param1 + 0x20);
		    local_18 = CONCAT44(local_4,local_8);
		    local_20 = CONCAT44(local_c,local_10);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x178) * 4))
		              (*(int **)(param1 + 0x20),&local_20,*(undefined4 *)(iVar2 + 0x17c));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsPremiumExp ---
		void Gameplay_Combat_View_Players_CombatPlayerLevelView__set_IsPremiumExp
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  iVar2 = 0x10;
		  if (param3 == 0) {
		    iVar2 = 0x14;
		  }
		  uVar1 = *(uint *)(param1 + iVar2);
		  local_8 = (float4)((float)(uVar1 >> 0x10 & 0xff) / 255.0);
		  local_4 = (float4)((float)(uVar1 >> 0x18) / 255.0);
		  local_10 = (float4)((float)(uVar1 & 0xff) / 255.0);
		  local_c = (float4)((float)(uVar1 >> 8 & 0xff) / 255.0);
		  iVar2 = **(int **)(param1 + 0x20);
		  local_18 = CONCAT44(local_4,local_8);
		  local_20 = CONCAT44(local_c,local_10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x178) * 4))
		            (*(int **)(param1 + 0x20),&local_20,*(undefined4 *)(iVar2 + 0x17c));
		  return;
		}
		*/

}
