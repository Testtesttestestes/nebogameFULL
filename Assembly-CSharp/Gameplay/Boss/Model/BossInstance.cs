using System;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Events;
using Il2CppDummyDll;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B90 RID: 2960
	[Token(Token = "0x2000B90")]
	public class BossInstance : IDisposable
	{
		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E89")]
		public BossInstanceModel Model
		{
			[Token(Token = "0x600481D")]
			[Address(RVA = "0x96A0", Offset = "0x96A0", VA = "0x96A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E8A")]
		public BossInstanceController Controller
		{
			[Token(Token = "0x600481E")]
			[Address(RVA = "0x96A1", Offset = "0x96A1", VA = "0x96A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x0600481F RID: 18463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E8B")]
		public BossInstanceEvents Events
		{
			[Token(Token = "0x600481F")]
			[Address(RVA = "0x96A2", Offset = "0x96A2", VA = "0x96A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		// (set) Token: 0x06004821 RID: 18465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E8C")]
		public ulong CurrentHealth
		{
			[Token(Token = "0x6004820")]
			[Address(RVA = "0x96A3", Offset = "0x96A3", VA = "0x96A3")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004821")]
			[Address(RVA = "0x96A4", Offset = "0x96A4", VA = "0x96A4")]
			set
			{
			}
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004822")]
		[Address(RVA = "0x96A5", Offset = "0x96A5", VA = "0x96A5")]
		public BossInstance(InstanceInfo instanceInfo)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Model_BossInstance___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int param1_01;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57879 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossInstanceController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Events_BossInstanceEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossInstanceModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57879 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Boss_Events_BossInstanceEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80dec7b9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dec7b9:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80dec865;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dec865:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  iVar6 = unnamed_function_1417(Gameplay_Boss_Model_BossInstanceModel_TypeInfo);
		  if (DAT_ram_00a57881 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInviteData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BossInviteData__TypeInfo);
		    DAT_ram_00a57881 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BossInviteData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BossInviteData___ctor__);
		  *(undefined4 *)(iVar6 + 0x2c) = param1_00;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar6,uVar4,0);
		  *(undefined4 *)(iVar6 + 0xc) = uVar2;
		  *(int *)(param1 + 8) = iVar6;
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(Gameplay_Boss_Controller_BossInstanceController_TypeInfo);
		  if (DAT_ram_00a578c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_BossInstanceModel__BossInstanceEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BossService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a578c5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1_01,iVar6,uVar2,
		             Method_MVC_AbstractController_BossInstanceModel__BossInstanceEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BossService___);
		  *(undefined4 *)(param1_01 + 0x18) = uVar2;
		  *(int *)(param1 + 0xc) = param1_01;
		  return;
		}
		*/

		}

		// Token: 0x06004823 RID: 18467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004823")]
		[Address(RVA = "0x96A6", Offset = "0x96A6", VA = "0x96A6")]
		private void SetupMvc()
		{
		}

		// Token: 0x06004824 RID: 18468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004824")]
		[Address(RVA = "0x96A7", Offset = "0x96A7", VA = "0x96A7")]
		private void DisposeMvc()
		{
		/* --- GHIDRA: DisposeMvc ---
		void Gameplay_Boss_Model_BossInstance__DisposeMvc(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (*(int *)(param1 + 0xc) != 0) {
		    MVC_AbstractController__Run(*(int *)(param1 + 0xc),0);
		    piVar1 = *(int **)(param1 + 0xc);
		    if (piVar1 != (int *)0x0) {
		      (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))
		                (piVar1,*(undefined4 *)(*piVar1 + 0xec));
		    }
		  }
		  piVar1 = *(int **)(param1 + 8);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe8) * 4))(piVar1,*(undefined4 *)(*piVar1 + 0xec));
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004825 RID: 18469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004825")]
		[Address(RVA = "0x96A8", Offset = "0x96A8", VA = "0x96A8", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		uint Gameplay_Boss_Model_BossInstance__Dispose(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(*(int *)(param1 + 0x38) + 0x18) == 1);
		}
		*/

		}

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0x8")]
		private BossInstanceModel _model;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0xC")]
		private BossInstanceController _controller;

		// Token: 0x04002795 RID: 10133
		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0x10")]
		private BossInstanceEvents _events;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Events ---
		undefined8 Gameplay_Boss_Model_BossInstance__get_Events(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(*(int *)(param1 + 8) + 0x28) + 0x28);
		}
		*/


		/* --- GHIDRA: get_CurrentHealth ---
		void Gameplay_Boss_Model_BossInstance__get_CurrentHealth
		               (int param1,longlong param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(*(int *)(param1 + 8) + 0x28);
		  if (*(longlong *)(iVar1 + 0x28) != param2) {
		    *(longlong *)(iVar1 + 0x28) = param2;
		    iVar1 = *(int *)(*(int *)(param1 + 0x10) + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentHealth ---
		void Gameplay_Boss_Model_BossInstance__set_CurrentHealth
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Boss_Model_BossInstance___ctor(param1,param1);
		  Gameplay_Boss_Controller_BossController__AddBoss(*(undefined4 *)(param1 + 8),param2,param1);
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0xc),0);
		  return;
		}
		*/

}
