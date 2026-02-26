using System;
using Gameplay.UserInterface.Menu.Settings.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Menu.Settings.Control
{
	// Token: 0x020003DF RID: 991
	[Token(Token = "0x20003DF")]
	public class SettingsController : AbstractController<SettingsModel, SettingsEvents>
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001730")]
		[Address(RVA = "0x68EF", Offset = "0x68EF", VA = "0x68EF")]
		public SettingsController(SettingsModel model, SettingsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsController___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5988b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a5988b = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107ef7d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107ef7d:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined1 *)(iVar2 + 10) = (undefined1)param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x8107f01d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Data_User_IUserSettings_TypeInfo,1);
		code_r0x8107f01d:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001731")]
		[Address(RVA = "0x68F0", Offset = "0x68F0", VA = "0x68F0")]
		public void SetCombatAnimationsEnabled(bool value)
		{
		/* --- GHIDRA: SetCombatAnimationsEnabled ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsController__SetCombatAnimationsEnabled
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5988c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a5988c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107f0dc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107f0dc:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined1 *)(iVar2 + 0xb) = (undefined1)param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x8107f17c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Data_User_IUserSettings_TypeInfo,1);
		code_r0x8107f17c:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001732")]
		[Address(RVA = "0x68F1", Offset = "0x68F1", VA = "0x68F1")]
		public void SetCombatSpellAnimationsEnabled(bool value)
		{
		/* --- GHIDRA: SetCombatSpellAnimationsEnabled ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsController__SetCombatSpellAnimationsEnabled
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5988d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a5988d = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar4 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8107f23b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8107f23b:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined1 *)(iVar2 + 0xc) = (undefined1)param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar4 = *(int **)(iVar2 + 0x10);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x8107f2db;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Data_User_IUserSettings_TypeInfo,1);
		code_r0x8107f2db:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001733")]
		[Address(RVA = "0x68F2", Offset = "0x68F2", VA = "0x68F2")]
		public void SetWorldMovementAnimationsEnabled(bool value)
		{
		/* --- GHIDRA: SetWorldMovementAnimationsEnabled ---
		void Gameplay_UserInterface_Menu_Settings_Control_SettingsController__SetWorldMovementAnimationsEnabled
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5988e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_SettingsModel__SettingsEvents__SettingsController__SettingsView__Dispose__
		              );
		    DAT_ram_00a5988e = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_SettingsModel__SettingsEvents__SettingsController__SettingsView__Dispose__
		            );
		  return;
		}
		*/

		}
	}
}
