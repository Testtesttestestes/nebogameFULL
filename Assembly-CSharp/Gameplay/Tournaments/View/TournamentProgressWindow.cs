using System;
using Core.Data.Tournaments;
using Gameplay.Tournaments.Controller;
using Il2CppDummyDll;
using Protocol.Common;
using TMPro;
using UI;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	public class TournamentProgressWindow : ClosableBaseWindow<TournamentProgressWindow.TournamentProgressWindowArgs>
	{
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000510")]
		public override string WindowId
		{
			[Token(Token = "0x6001C5A")]
			[Address(RVA = "0x6DD9", Offset = "0x6DD9", VA = "0x6DD9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000511")]
		public TextMeshProUGUI TournamentStatus
		{
			[Token(Token = "0x6001C5B")]
			[Address(RVA = "0x6DDA", Offset = "0x6DDA", VA = "0x6DDA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000512")]
		public TextMeshProUGUI TournamentState
		{
			[Token(Token = "0x6001C5C")]
			[Address(RVA = "0x6DDB", Offset = "0x6DDB", VA = "0x6DDB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000513")]
		public TournamentProgressInfoBox InfoBox
		{
			[Token(Token = "0x6001C5D")]
			[Address(RVA = "0x6DDC", Offset = "0x6DDC", VA = "0x6DDC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000514")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6001C5E")]
			[Address(RVA = "0x6DDD", Offset = "0x6DDD", VA = "0x6DDD")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000515")]
		public Button RulesButton
		{
			[Token(Token = "0x6001C5F")]
			[Address(RVA = "0x6DDE", Offset = "0x6DDE", VA = "0x6DDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000516")]
		public BacktimeViewUGUI Timer
		{
			[Token(Token = "0x6001C60")]
			[Address(RVA = "0x6DDF", Offset = "0x6DDF", VA = "0x6DDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000517")]
		public GameObject WinImage
		{
			[Token(Token = "0x6001C61")]
			[Address(RVA = "0x6DE0", Offset = "0x6DE0", VA = "0x6DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000518")]
		public GameObject LoseImage
		{
			[Token(Token = "0x6001C62")]
			[Address(RVA = "0x6DE1", Offset = "0x6DE1", VA = "0x6DE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x00005EE0 File Offset: 0x000040E0
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000519")]
		public bool AllowClose
		{
			[Token(Token = "0x6001C63")]
			[Address(RVA = "0x6DE2", Offset = "0x6DE2", VA = "0x6DE2")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C64")]
			[Address(RVA = "0x6DE3", Offset = "0x6DE3", VA = "0x6DE3")]
			set
			{
			}
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x6DE4", Offset = "0x6DE4", VA = "0x6DE4", Slot = "22")]
		protected override void OnShow(TournamentProgressWindow.TournamentProgressWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Tournaments_View_TournamentProgressWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58503 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__OnClose__
		              );
		    DAT_ram_00a58503 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__OnClose__
		            );
		  if (*(char *)(param1 + 0x68) != '\0') {
		    iVar1 = **(int **)(param1 + 100);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 100),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 100) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x6DE5", Offset = "0x6DE5", VA = "0x6DE5", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		int * Gameplay_Tournaments_View_TournamentProgressWindow__OnClose
		                (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  uint *puVar7;
		  int *piVar8;
		  int param1_00;
		  int iVar9;
		  int *piVar10;
		  undefined4 uVar11;
		  longlong local_28;
		  longlong local_20;
		  longlong local_18;
		  int *local_10;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58504 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Fighter___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Fighter___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fighter__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Fighter__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_TournamentBattleInfoListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_View_TournamentBattleInfoListElement___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_View_TournamentProgressWindow___c__DisplayClass37_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_View_TournamentProgressWindow___c__DisplayClass37_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_Fighter__Fighter___ctor__);
		    DAT_ram_00a58504 = '\x01';
		  }
		  local_8 = 0;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Tournaments_View_TournamentProgressWindow___c__DisplayClass37_0_TypeInfo
		                    );
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x4c),0);
		  local_10 = &local_8;
		  local_18 = ZEXT48(&local_4) << 0x20;
		  do {
		    piVar10 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(iVar9 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80efd107;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80efd34a:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80efd352;
		    }
		code_r0x80efd107:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar4,piVar10,puVar4[1]);
		    piVar10 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80efd34a;
		    if (iVar9 == 0) goto code_r0x80efd39b;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar4 = (undefined4 *)(piVar8[1] * 8 + iVar9 + 200);
		          goto code_r0x80efd1e4;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80efd32c:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80efd352;
		    }
		code_r0x80efd1e4:
		    DAT_ram_009d3e38 = 0;
		    piVar10 = (int *)import::env::invoke_iii(*puVar4,piVar10,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80efd32c;
		    if (piVar10 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar10 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)
		          ) || (*(int *)(*(int *)(*piVar10 + 100) +
		                         (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		                UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar10,
		                   UnityEngine_Transform_TypeInfo);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80efd352;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar10,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar5,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80efd352:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar5);
		    DAT_ram_009d3e38 = 0;
		    local_18 = CONCAT44(local_18._4_4_,*puVar4);
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		code_r0x80efd39b:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar10 = (int *)*local_10;
		      if (piVar10 != (int *)0x0) {
		        iVar9 = *piVar10;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		              puVar7 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80efd42b;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x80efd42b:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar10,puVar7[1]);
		      }
		      if ((int)local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint((int)local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar9 = *(int *)(*(int *)(param2 + 0xc) + 0x14);
		      *(int *)(iVar3 + 8) = iVar9;
		      uVar11 = *(undefined4 *)(iVar9 + 0x2c);
		      uVar5 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar5,iVar3,
		                 Method_Gameplay_Tournaments_View_TournamentProgressWindow___c__DisplayClass37_0__Init_b__0__
		                 ,0);
		      uVar5 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                        (uVar11,uVar5,Method_System_Linq_Enumerable_Where_Fighter___);
		      iVar3 = System_Linq_Enumerable__Select_object__object_
		                        (uVar5,Method_System_Linq_Enumerable_ToList_Fighter___);
		      piVar10 = (int *)Mono_Security_ASN1Convert__ToOid
		                                 (Gameplay_Tournaments_View_TournamentBattleInfoListElement___TypeInfo
		                                  ,*(int *)(iVar3 + 0xc) / 2);
		      if (0 < *(int *)(iVar3 + 0xc)) {
		        uVar2 = 0;
		        do {
		          uVar5 = *(undefined4 *)(param1 + 0x4c);
		          uVar11 = *(undefined4 *)(param1 + 0x48);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          piVar8 = (int *)func_ii_6805(uVar11,uVar5,
		                                       Method_UnityEngine_Object_Instantiate_TournamentBattleInfoListElement___
		                                      );
		          uVar5 = System_Linq_Enumerable__ToList_object_
		                            (iVar3,uVar2,Method_System_Collections_Generic_List_Fighter__get_Item__)
		          ;
		          uVar11 = System_Linq_Enumerable__ToList_object_
		                             (iVar3,uVar2 | 1,
		                              Method_System_Collections_Generic_List_Fighter__get_Item__);
		          local_20 = 0;
		          System_Text_Formatting_StringView__get_IsEmpty
		                    (&local_20,uVar5,uVar11,Method_System_ValueTuple_Fighter__Fighter___ctor__);
		          local_18 = local_20;
		          local_28 = local_20;
		          (**(code **)((ulonglong)*(uint *)(*piVar8 + 0xe8) * 4))
		                    (piVar8,&local_28,*(undefined4 *)(*piVar8 + 0xec));
		          if (DAT_ram_00a584ed == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_UserInfo__TypeInfo);
		            DAT_ram_00a584ed = '\x01';
		          }
		          iVar9 = piVar8[9];
		          do {
		            iVar6 = 0;
		            param1_00 = UnityEngine_UI_Image__set_sprite(iVar9,param3,0);
		            uVar5 = System_Action_UserInfo__TypeInfo;
		            if ((param1_00 != 0) &&
		               (iVar6 = func_ii_1082(param1_00,System_Action_UserInfo__TypeInfo), iVar6 == 0)) {
		              System_Activator__CreateInstance(param1_00,uVar5);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            iVar6 = func_ii_4329(piVar8 + 9,iVar6,iVar9);
		            bVar1 = iVar6 != iVar9;
		            iVar9 = iVar6;
		          } while (bVar1);
		          iVar9 = func_ii_1082(piVar8,*(undefined4 *)(*piVar10 + 0x20));
		          if (iVar9 == 0) {
		            uVar5 = func_ii_1083();
		            func_ii_1050(uVar5,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          *(int **)((int)piVar10 + uVar2 * 2 + 0x10) = piVar8;
		          uVar2 = uVar2 + 2;
		        } while ((int)uVar2 < *(int *)(iVar3 + 0xc));
		      }
		      return piVar10;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x17e,&local_18);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 != 1) {
		    import::env::__resumeException(uVar5);
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
		*/

		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x6DE6", Offset = "0x6DE6", VA = "0x6DE6")]
		public TournamentBattleInfoListElement[] Init(TournamentData tournamentData, Action<UserInfo> callback)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Tournaments_View_TournamentProgressWindow__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Elements_RightPanel_TitleWithLevel__set_Level(*(undefined4 *)(param1 + 0x50),param2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x6DE7", Offset = "0x6DE7", VA = "0x6DE7")]
		public void UpdateTimer(BackTime backTime)
		{
		/* --- GHIDRA: UpdateTimer ---
		uint Gameplay_Tournaments_View_TournamentProgressWindow__UpdateTimer(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(param1 + 0x69);
		}
		*/

		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x6DE8", Offset = "0x6DE8", VA = "0x6DE8", Slot = "17")]
		public override bool CheckForClose()
		{
		/* --- GHIDRA: CheckForClose ---
		void Gameplay_Tournaments_View_TournamentProgressWindow__CheckForClose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  undefined4 param4;
		  int iVar2;
		  
		  if (DAT_ram_00a58505 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentProgressViewMediator_TypeInfo);
		    DAT_ram_00a58505 = '\x01';
		  }
		  if (*(char *)(param1 + 0x68) == '\0') {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_WindowArgs__
		                        );
		    iVar2 = **(int **)(iVar1 + 0x18);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                          (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x104));
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_WindowArgs__
		                        );
		    iVar2 = **(int **)(iVar1 + 0x18);
		    param3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                       (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x114));
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(undefined4 *)(iVar1 + 0x18);
		    param1_00 = (int *)unnamed_function_1417
		                                 (
		                                 Gameplay_Tournaments_Controller_TournamentProgressViewMediator_TypeInfo
		                                 );
		    if (DAT_ram_00a5852b == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow___ctor__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView___ctor__
		                );
		      Mono_Security_ASN1__get_Item
		                (&System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__TypeInfo)
		      ;
		      DAT_ram_00a5852b = '\x01';
		    }
		    param1_00[6] = 0x42940000;
		    param1_00[7] = 0x43420000;
		    param1_00[8] = 0x436c0000;
		    param1_00[9] = 0x3f800000;
		    iVar1 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		              (iVar1,
		               Method_System_Collections_Generic_Dictionary_ulong__TournamentPlayerBattleView___ctor__
		              );
		    param1_00[0xc] = iVar1;
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3,param4,
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentProgressWindow___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(undefined1 *)(param1 + 0x68) = 1;
		    *(int **)(param1 + 100) = param1_00;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x6DE9", Offset = "0x6DE9", VA = "0x6DE9")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x6DEA", Offset = "0x6DEA", VA = "0x6DEA")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Tournaments_View_TournamentProgressWindow__DestroyMVC(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58506 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs___ctor__
		              );
		    DAT_ram_00a58506 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x69) = 1;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x6DEB", Offset = "0x6DEB", VA = "0x6DEB")]
		public TournamentProgressWindow()
		{
		}

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Tournaments/TournamentProgressWindow";

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TournamentProgressInfoBox _infoBox;

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TournamentBattleInfoListElement _listElementPrefab;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x4C")]
		[Header("General page")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BacktimeViewUGUI _timer;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _tournamentStatus;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _tournamentState;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _winImage;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _loseImage;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x64")]
		private TournamentProgressViewMediator _mediator;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x68")]
		private bool _mvcSetUp;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x69")]
		private bool _allowClose;

		// Token: 0x020004B2 RID: 1202
		[Token(Token = "0x20004B2")]
		public class TournamentProgressWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001C6D RID: 7277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001C6D")]
			[Address(RVA = "0x6DEC", Offset = "0x6DEC", VA = "0x6DEC")]
			public TournamentProgressWindowArgs()
			{
			}

			// Token: 0x04000F78 RID: 3960
			[Token(Token = "0x4000F78")]
			[FieldOffset(Offset = "0x18")]
			public TournamentsController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AllowClose ---
		void Gameplay_Tournaments_View_TournamentProgressWindow__get_AllowClose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58501 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__get_BackButton__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_WindowWhitCloseButton_TournamentProgressWindow_TournamentProgressWindowArgs__get_CloseButton__
		              );
		    DAT_ram_00a58501 = '\x01';
		  }
		  *(char *)(param1 + 0x69) = (char)param2;
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(param1 + 0x38),param2,0);
		  System_Linq_Enumerable__First_object_
		            (*(undefined4 *)(param1 + 0x34),(uint)*(byte *)(param1 + 0x69),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_AllowClose ---
		void Gameplay_Tournaments_View_TournamentProgressWindow__set_AllowClose
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58502 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__OnShow__
		              );
		    DAT_ram_00a58502 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_TournamentProgressWindow_TournamentProgressWindowArgs__OnShow__
		              );
		  Gameplay_Tournaments_View_TournamentProgressWindow__CheckForClose(param1,param1);
		  return;
		}
		*/

}
