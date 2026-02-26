using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.GameActivityRouting;
using Gameplay.World.Events;
using Il2CppDummyDll;
using MVC;
using Protocol.Announcements;
using UI.Windows;

namespace Gameplay.Announcements.Model
{
	// Token: 0x02000DA4 RID: 3492
	[Token(Token = "0x2000DA4")]
	public class AnnouncementsModel : AbstractModel
	{
		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600554E RID: 21838 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600554F RID: 21839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001154")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x600554E")]
			[Address(RVA = "0xA2EF", Offset = "0xA2EF", VA = "0xA2EF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600554F")]
			[Address(RVA = "0xA2F0", Offset = "0xA2F0", VA = "0xA2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06005550 RID: 21840 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005551 RID: 21841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001155")]
		public IRouter Router
		{
			[Token(Token = "0x6005550")]
			[Address(RVA = "0xA2F1", Offset = "0xA2F1", VA = "0xA2F1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005551")]
			[Address(RVA = "0xA2F2", Offset = "0xA2F2", VA = "0xA2F2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06005552 RID: 21842 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005553 RID: 21843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001156")]
		public PopupScheduleManager PopupScheduler
		{
			[Token(Token = "0x6005552")]
			[Address(RVA = "0xA2F3", Offset = "0xA2F3", VA = "0xA2F3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005553")]
			[Address(RVA = "0xA2F4", Offset = "0xA2F4", VA = "0xA2F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06005554 RID: 21844 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005555 RID: 21845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001157")]
		public PopupController PopupController
		{
			[Token(Token = "0x6005554")]
			[Address(RVA = "0xA2F5", Offset = "0xA2F5", VA = "0xA2F5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005555")]
			[Address(RVA = "0xA2F6", Offset = "0xA2F6", VA = "0xA2F6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06005556 RID: 21846 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005557 RID: 21847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001158")]
		public PopupScheduleManager.Args PopupScheduledArgs
		{
			[Token(Token = "0x6005556")]
			[Address(RVA = "0xA2F7", Offset = "0xA2F7", VA = "0xA2F7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005557")]
			[Address(RVA = "0xA2F8", Offset = "0xA2F8", VA = "0xA2F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06005558 RID: 21848 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005559 RID: 21849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001159")]
		public WorldEngineEvents WorldEngineEvents
		{
			[Token(Token = "0x6005558")]
			[Address(RVA = "0xA2F9", Offset = "0xA2F9", VA = "0xA2F9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005559")]
			[Address(RVA = "0xA2FA", Offset = "0xA2FA", VA = "0xA2FA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555A")]
		[Address(RVA = "0xA2FB", Offset = "0xA2FB", VA = "0xA2FB", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Announcements_Model_AnnouncementsModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58826 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AnnouncementsData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_AnnouncementsData__TypeInfo)
		    ;
		    DAT_ram_00a58826 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_AnnouncementsData__TypeInfo);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param8,0);
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 0x20) = param7;
		  *(undefined4 *)(param1 + 0x1c) = param6;
		  *(undefined4 *)(param1 + 0x18) = param5;
		  return;
		}
		*/

		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555B")]
		[Address(RVA = "0xA2FC", Offset = "0xA2FC", VA = "0xA2FC")]
		public AnnouncementsModel(IDictProvider dictProvider, IRouter router, WorldEngineEvents worldEvents, PopupScheduleManager popupScheduler, PopupController popupController, PopupScheduleManager.Args popupScheduleArgs, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Announcements_Model_AnnouncementsModel___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58827 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AnnouncementsData__get_Count__);
		    DAT_ram_00a58827 = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(param1 + 0xc) + 0xc);
		}
		*/

		}

		// Token: 0x0600555C RID: 21852 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		[Token(Token = "0x600555C")]
		[Address(RVA = "0xA2FD", Offset = "0xA2FD", VA = "0xA2FD")]
		public int GetNotificationsCount()
		{
		/* --- GHIDRA: GetNotificationsCount ---
		void Gameplay_Announcements_Model_AnnouncementsModel__GetNotificationsCount
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58828 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_AnnouncementsData__ulong___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_AnnouncementsData__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_AnnouncementsData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_AnnouncementsData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AnnouncementsData__AddLast__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Announcements_Model_AnnouncementsModel___c__Add_b__28_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo);
		    DAT_ram_00a58828 = '\x01';
		  }
		  if (*(int *)(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo + 0x5c)
		      ;
		    }
		    uVar4 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Func_AnnouncementsData__ulong__TypeInfo);
		    func_ii_7542(iVar7,uVar4,
		                 Method_Gameplay_Announcements_Model_AnnouncementsModel___c__Add_b__28_0__,0);
		    *(int *)(*(int *)(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo + 0x5c) + 4) =
		         iVar7;
		  }
		  uVar1 = 0;
		  piVar2 = (int *)System_Func_object__ulong____ctor
		                            (param2,iVar7,
		                             Method_System_Linq_Enumerable_OrderBy_AnnouncementsData__ulong___);
		  iVar7 = *piVar2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_AnnouncementsData__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f31fe1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,
		                                System_Collections_Generic_IEnumerable_AnnouncementsData__TypeInfo,0
		                               );
		code_r0x80f31fe1:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar2 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar6 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f320af;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f32223:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3222b;
		    }
		code_r0x80f320af:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar6,piVar2,puVar6[1]);
		    piVar2 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f32223;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x80f32274;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_AnnouncementsData__TypeInfo == *piVar8) {
		          puVar6 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80f32189;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_AnnouncementsData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3220f:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f3222b;
		    }
		code_r0x80f32189:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar6,piVar2,puVar6[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f3220f;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x174,*(undefined4 *)(param1 + 0xc)
		               ,uVar4,Method_System_Collections_Generic_LinkedList_AnnouncementsData__AddLast__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f3222b:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar7 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80f32274:
		      piVar2 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f322ec;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80f322ec:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a5,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0;
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555D")]
		[Address(RVA = "0xA2FE", Offset = "0xA2FE", VA = "0xA2FE")]
		public void Add(IEnumerable<AnnouncementsData> values)
		{
		/* --- GHIDRA: Add ---
		uint Gameplay_Announcements_Model_AnnouncementsModel__Add
		               (int param1,undefined8 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58829 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SingleOrDefault_AnnouncementsData___);
		    Mono_Security_ASN1__get_Item(&System_Func_AnnouncementsData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Announcements_Model_AnnouncementsModel___c__DisplayClass29_0__TryGetNotification_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Announcements_Model_AnnouncementsModel___c__DisplayClass29_0_TypeInfo);
		    DAT_ram_00a58829 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Announcements_Model_AnnouncementsModel___c__DisplayClass29_0_TypeInfo)
		  ;
		  *(undefined8 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(param1 + 0xc);
		  param1_00 = unnamed_function_1417(System_Func_AnnouncementsData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Gameplay_Announcements_Model_AnnouncementsModel___c__DisplayClass29_0__TryGetNotification_b__0__
		             ,0);
		  iVar1 = UI_SimpleIconValue__set_Value
		                    (param1_01,param1_00,
		                     Method_System_Linq_Enumerable_SingleOrDefault_AnnouncementsData___);
		  *param3 = iVar1;
		  return (uint)(iVar1 != 0);
		}
		*/

		}

		// Token: 0x0600555E RID: 21854 RVA: 0x0000F708 File Offset: 0x0000D908
		[Token(Token = "0x600555E")]
		[Address(RVA = "0xA2FF", Offset = "0xA2FF", VA = "0xA2FF")]
		public bool TryGetNotification(ulong id, out AnnouncementsData value)
		{
		/* --- GHIDRA: TryGetNotification ---
		void Gameplay_Announcements_Model_AnnouncementsModel__TryGetNotification
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5882a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AnnouncementsData__Remove__);
		    DAT_ram_00a5882a = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Announcements_Model_AnnouncementsModel__Add(param1,param2,&local_4,auStack_10);
		  if (iVar1 != 0) {
		    System_Net_WebConnection__StartOperation
		              (*(undefined4 *)(param1 + 0xc),local_4,
		               Method_System_Collections_Generic_LinkedList_AnnouncementsData__Remove__);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600555F")]
		[Address(RVA = "0xA300", Offset = "0xA300", VA = "0xA300")]
		public void Remove(ulong id)
		{
		/* --- GHIDRA: Remove ---
		undefined4 Gameplay_Announcements_Model_AnnouncementsModel__Remove(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5882c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_AnnouncementsData__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AnnouncementsData__get_First__);
		    DAT_ram_00a5882c = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(param1 + 0xc) + 8) + 0x14);
		}
		*/

		}

		// Token: 0x06005560 RID: 21856 RVA: 0x0000F720 File Offset: 0x0000D920
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x1D2D", Offset = "0x1D2D", VA = "0x1D2D")]
		public bool TryCreate(Announcement value, out AnnouncementsData data)
		{
			return default(bool);
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005561")]
		[Address(RVA = "0xA301", Offset = "0xA301", VA = "0xA301")]
		public AnnouncementsData GetCurrent()
		{
		/* --- GHIDRA: GetCurrent ---
		void Gameplay_Announcements_Model_AnnouncementsModel__GetCurrent(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5882d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo);
		    DAT_ram_00a5882d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Announcements_Model_AnnouncementsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04002E35 RID: 11829
		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0xC")]
		private readonly LinkedList<AnnouncementsData> _notifications;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_WorldEngineEvents ---
		void Gameplay_Announcements_Model_AnnouncementsModel__set_WorldEngineEvents
		               (int param1,undefined4 param2)
		
		{
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

}
