using System;
using System.Collections.Generic;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.Schedule
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	public class WorldAxisScheduleView : MonoBehaviour
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A4")]
		private Dictionary<ColossusBattleData.State, Sprite> BgByStateDict
		{
			[Token(Token = "0x60011D3")]
			[Address(RVA = "0x1DCF", Offset = "0x1DCF", VA = "0x1DCF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A5")]
		private Dictionary<ColossusBattleData.State, Sprite> SwordsIconByStateDict
		{
			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x1DD0", Offset = "0x1DD0", VA = "0x1DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A6")]
		public TopRatingTable TopRatingTable
		{
			[Token(Token = "0x60011D5")]
			[Address(RVA = "0x63D0", Offset = "0x63D0", VA = "0x63D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A7")]
		public TextMeshProUGUI ColossusBattleHeader
		{
			[Token(Token = "0x60011D6")]
			[Address(RVA = "0x63D1", Offset = "0x63D1", VA = "0x63D1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A8")]
		public BacktimeViewUGUI Backtime
		{
			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x63D2", Offset = "0x63D2", VA = "0x63D2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A9")]
		public TextMeshProUGUI ParticipationDescription
		{
			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x63D3", Offset = "0x63D3", VA = "0x63D3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AA")]
		public Button RedButton
		{
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x63D4", Offset = "0x63D4", VA = "0x63D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AB")]
		public Button ToWorldAxisButton
		{
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x63D5", Offset = "0x63D5", VA = "0x63D5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AC")]
		public Button ColossusInfoButton
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x63D6", Offset = "0x63D6", VA = "0x63D6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AD")]
		public GameAssetViewRawImage ColossusAvatar
		{
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0x63D7", Offset = "0x63D7", VA = "0x63D7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x63D8", Offset = "0x63D8", VA = "0x63D8")]
		public void InitBattles(IEnumerable<ColossusBattleListElement.ColossusBattleListElementArgs> battles)
		{
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x63D9", Offset = "0x63D9", VA = "0x63D9")]
		public WorldAxisScheduleView()
		{
		}

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _colossusAvatar;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ColossusBattleListElement _listElementPrefab;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TopRatingTable _topRatingTable;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _colossusBattleHeader;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _backtime;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _participationDescription;

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _redButton;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _toWorldAxisButton;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _colossusInfoButton;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private WorldAxisScheduleView.SpriteByState[] _bgByState;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private WorldAxisScheduleView.SpriteByState[] _swordsIconByState;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ColossusBattleData.State, Sprite> _bgByStateDict;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x44")]
		private Dictionary<ColossusBattleData.State, Sprite> _swordsIconByStateDict;

		// Token: 0x020002F3 RID: 755
		[Token(Token = "0x20002F3")]
		[Serializable]
		public class SpriteByState
		{
			// Token: 0x060011DF RID: 4575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011DF")]
			[Address(RVA = "0x63DA", Offset = "0x63DA", VA = "0x63DA")]
			public SpriteByState()
			{
			}

			// Token: 0x0400094A RID: 2378
			[Token(Token = "0x400094A")]
			[FieldOffset(Offset = "0x8")]
			public ColossusBattleData.State State;

			// Token: 0x0400094B RID: 2379
			[Token(Token = "0x400094B")]
			[FieldOffset(Offset = "0xC")]
			public Sprite Sprite;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BgByStateDict ---
		int Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView__get_BgByStateDict
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int param1_01;
		  int param1_02;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58b98 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_WorldAxisScheduleView_SpriteByState__ColossusBattleData_State__Sprite___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_WorldAxisScheduleView_SpriteByState__ColossusBattleData_State__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_WorldAxisScheduleView_SpriteByState__Sprite__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c__get_SwordsIconByStateDict_b__17_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c__get_SwordsIconByStateDict_b__17_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo);
		    DAT_ram_00a58b98 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 == 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x3c);
		    if (*(int *)(Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo + 0x74)
		        == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)
		              (Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo + 0x5c);
		    param1_01 = puVar2[3];
		    iVar1 = Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo;
		    if (param1_01 == 0) {
		      if (*(int *)(Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo + 0x74
		                  ) == 0) {
		        func_ii_306000(Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo);
		        puVar2 = *(undefined4 **)
		                  (Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo + 0x5c
		                  );
		      }
		      uVar3 = *puVar2;
		      param1_01 = unnamed_function_1417
		                            (
		                            System_Func_WorldAxisScheduleView_SpriteByState__ColossusBattleData_State__TypeInfo
		                            );
		      System_Action_object____ctor
		                (param1_01,uVar3,
		                 Method_Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c__get_SwordsIconByStateDict_b__17_0__
		                 ,0);
		      iVar1 = Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo;
		      *(int *)(*(int *)(Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo +
		                       0x5c) + 0xc) = param1_01;
		    }
		    if (*(int *)(iVar1 + 0x74) == 0) {
		      func_ii_306000(iVar1);
		      iVar1 = Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo;
		    }
		    puVar2 = *(undefined4 **)(iVar1 + 0x5c);
		    param1_02 = puVar2[4];
		    if (param1_02 == 0) {
		      if (*(int *)(iVar1 + 0x74) == 0) {
		        func_ii_306000(iVar1);
		        puVar2 = *(undefined4 **)
		                  (Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo + 0x5c
		                  );
		      }
		      uVar3 = *puVar2;
		      param1_02 = unnamed_function_1417
		                            (System_Func_WorldAxisScheduleView_SpriteByState__Sprite__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (param1_02,uVar3,
		                 Method_Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c__get_SwordsIconByStateDict_b__17_1__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView___c_TypeInfo +
		                       0x5c) + 0x10) = param1_02;
		    }
		    iVar1 = System_Linq_Enumerable__ToDictionary_Int32Enum__Int32Enum__object_
		                      (param1_00,param1_01,param1_02,
		                       Method_System_Linq_Enumerable_ToDictionary_WorldAxisScheduleView_SpriteByState__ColossusBattleData_State__Sprite___
		                      );
		    *(int *)(param1 + 0x44) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_ColossusAvatar ---
		void Gameplay_WorldAxis_Office_View_Schedule_WorldAxisScheduleView__get_ColossusAvatar
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 param2_00;
		  int *piVar8;
		  int local_18;
		  int **local_14;
		  int *local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58b99 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ColossusBattleData_State__Sprite__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ColossusBattleListElement_ColossusBattleListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_ColossusBattleListElement_ColossusBattleListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ColossusBattleListElement_ColossusBattleListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_ColossusBattleListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a58b99 = '\x01';
		  }
		  local_8 = 0;
		  local_c = (int *)0x0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x18),0);
		  local_10 = &local_8;
		  local_18 = 0;
		  local_14 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f7f817;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f7fa5a:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f7fa62;
		    }
		code_r0x80f7f817:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f7fa5a;
		    if (iVar7 == 0) goto code_r0x80f7faab;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 200);
		          goto code_r0x80f7f8f4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f7fa3c:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f7fa62;
		    }
		code_r0x80f7f8f4:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f7fa3c;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f7fa62;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f7fa62:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_18 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80f7faab:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_10;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f7fb3b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80f7fb3b:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar1 = 0;
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_ColossusBattleListElement_ColossusBattleListElementArgs__TypeInfo
		              == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80f7fbc3;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_ColossusBattleListElement_ColossusBattleListElementArgs__TypeInfo
		                                    ,0);
		code_r0x80f7fbc3:
		      local_c = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      local_18 = 0;
		      local_14 = &local_c;
		      do {
		        piVar5 = local_c;
		        iVar7 = *local_c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		              puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80f7fcd4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f7fff1:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f7fff9;
		        }
		code_r0x80f7fcd4:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f7fff1;
		        if (iVar7 == 0) {
		          iVar7 = 0;
		          goto code_r0x80f80042;
		        }
		        iVar7 = *local_c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_ColossusBattleListElement_ColossusBattleListElementArgs__TypeInfo
		                == *piVar8) {
		              puVar2 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80f7fdae;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_ColossusBattleListElement_ColossusBattleListElementArgs__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f7ffa1:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f7fff9;
		        }
		code_r0x80f7fdae:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f7ffa1;
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x248,param1,iVar7);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f7fff9;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,uVar3,
		                           *(undefined4 *)(*(int *)(iVar7 + 0x1c) + 8),
		                           Method_System_Collections_Generic_Dictionary_ColossusBattleData_State__Sprite__get_Item__
		                          );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f7fff9;
		        }
		        *(undefined4 *)(iVar7 + 0x20) = uVar3;
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x249,param1,iVar7);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f7fff9;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,uVar3,
		                           *(undefined4 *)(*(int *)(iVar7 + 0x1c) + 8),
		                           Method_System_Collections_Generic_Dictionary_ColossusBattleData_State__Sprite__get_Item__
		                          );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f7fff9;
		        }
		        *(undefined4 *)(iVar7 + 0x24) = uVar3;
		        uVar3 = *(undefined4 *)(param1 + 0x18);
		        param2_00 = *(undefined4 *)(param1 + 0x14);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f7fff9;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar3,
		                           Method_UnityEngine_Object_Instantiate_ColossusBattleListElement___);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f7fff9;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc,uVar3,iVar7,
		                   Method_UI_Elements_GenericList_GenericListElement_ColossusBattleListElement_ColossusBattleListElementArgs__Init__
		                  );
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar7 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f7fff9:
		      iVar7 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80f80042:
		          piVar5 = local_c;
		          DAT_ram_009d3e38 = 0;
		          if (local_c != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *local_c;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80f800ba;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar6 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x80f800ba:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (iVar7 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x24a,&local_18);
		      goto joined_r0x80f80108;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x247,&local_18);
		joined_r0x80f80108:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
