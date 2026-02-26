using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.User;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Menu.Settings.Model
{
	// Token: 0x020003DE RID: 990
	[Token(Token = "0x20003DE")]
	public class SettingsModel : AbstractModel
	{
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000403")]
		public IGame Game
		{
			[Token(Token = "0x600172A")]
			[Address(RVA = "0x68E9", Offset = "0x68E9", VA = "0x68E9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600172B")]
			[Address(RVA = "0x68EA", Offset = "0x68EA", VA = "0x68EA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000404")]
		public IUserSettings UserSettings
		{
			[Token(Token = "0x600172C")]
			[Address(RVA = "0x68EB", Offset = "0x68EB", VA = "0x68EB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600172D")]
			[Address(RVA = "0x68EC", Offset = "0x68EC", VA = "0x68EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x68ED", Offset = "0x68ED", VA = "0x68ED", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_UserInterface_Menu_Settings_Model_SettingsModel__Dispose
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a59889 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59889 = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(int **)(param1 + 0xc) = param2;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x148);
		        goto code_r0x8107ed9b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x8107ed9b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x68EE", Offset = "0x68EE", VA = "0x68EE")]
		public SettingsModel(IGame game, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Menu_Settings_Model_SettingsModel___ctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5988a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_SettingsModel__SettingsEvents___ctor__);
		    DAT_ram_00a5988a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_SettingsModel__SettingsEvents___ctor__);
		  return;
		}
		*/

		}
	}
}
