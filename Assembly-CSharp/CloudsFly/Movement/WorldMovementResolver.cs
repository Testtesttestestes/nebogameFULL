using System;
using Core.Data.User;
using Il2CppDummyDll;

namespace CloudsFly.Movement
{
	// Token: 0x02001315 RID: 4885
	[Token(Token = "0x2001315")]
	public class WorldMovementResolver
	{
		// Token: 0x06007411 RID: 29713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007411")]
		[Address(RVA = "0xBDDF", Offset = "0xBDDF", VA = "0xBDDF")]
		public WorldMovementResolver(IUserSettings userSettings)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		CloudsFly_Movement_WorldMovementResolver___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param1_00;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5969d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    DAT_ram_00a5969d = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 8);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param1_00 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8104aced;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param1_00 = (uint *)func_ii_1080(param1_01,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x8104aced:
		  iVar3 = (**(code **)((ulonglong)*param1_00 * 4))(param1_01,param1_00[1]);
		  if (*(char *)(iVar3 + 0xc) != '\0') {
		    uVar2 = CloudsFly_Movement_WorldMovementResolver__GetInstantMovementByType
		                      (param1_00,param2,param1_00);
		    return uVar2;
		  }
		  uVar2 = CloudsFly_Movement_WorldMovementResolver__GetMovementByType(param1_00,param2,param1_00);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06007412 RID: 29714 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007412")]
		[Address(RVA = "0xBDE0", Offset = "0xBDE0", VA = "0xBDE0")]
		public AbstractWorldMovement GetMovementByType(WorldMovementTypes type)
		{
		/* --- GHIDRA: GetMovementByType ---
		int CloudsFly_Movement_WorldMovementResolver__GetMovementByType
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5969e == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToFarIsleWorldMovementInstant_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToHomeInitialWorldMovementInstant_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToHomeWorldMovementInstant_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToIsleAfterLevelChangesInstant_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToLevelInstant_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToNextVisibleIsleWorldMovementInstant_TypeInfo)
		    ;
		    DAT_ram_00a5969e = '\x01';
		  }
		  if (param2 == 1) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToHomeInitialWorldMovementInstant_TypeInfo);
		  }
		  else if (param2 == 2) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToNextVisibleIsleWorldMovementInstant_TypeInfo)
		    ;
		  }
		  else if (param2 == 3) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToHomeWorldMovementInstant_TypeInfo);
		  }
		  else if (param2 == 4) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToIsleAfterLevelChangesInstant_TypeInfo);
		  }
		  else if (param2 == 5) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToFarIsleWorldMovementInstant_TypeInfo);
		  }
		  else if (param2 == 6) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToLevelInstant_TypeInfo);
		  }
		  else {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToHomeInitialWorldMovementInstant_TypeInfo);
		  }
		  if (DAT_ram_00a5969c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Tween__TypeInfo);
		    DAT_ram_00a5969c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Tween__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Tween___ctor__);
		  *(undefined4 *)(iVar1 + 8) = param1_00;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007413 RID: 29715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007413")]
		[Address(RVA = "0xBDE1", Offset = "0xBDE1", VA = "0xBDE1")]
		private AbstractWorldMovement GetInstantMovementByType(WorldMovementTypes type)
		{
		/* --- GHIDRA: GetInstantMovementByType ---
		int CloudsFly_Movement_WorldMovementResolver__GetInstantMovementByType
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5969f == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToFarIsleWorldMovement_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToHomeInitialWorldMovement_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToHomeWorldMovement_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToIsleAfterLevelChanges_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToLevel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_ToNextVisibleIsleWorldMovement_TypeInfo);
		    DAT_ram_00a5969f = '\x01';
		  }
		  if (param2 == 1) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToHomeInitialWorldMovement_TypeInfo);
		  }
		  else if (param2 == 2) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToNextVisibleIsleWorldMovement_TypeInfo);
		  }
		  else if (param2 == 3) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToHomeWorldMovement_TypeInfo);
		  }
		  else if (param2 == 4) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToIsleAfterLevelChanges_TypeInfo);
		  }
		  else if (param2 == 5) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToFarIsleWorldMovement_TypeInfo);
		  }
		  else if (param2 == 6) {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToLevel_TypeInfo);
		  }
		  else {
		    iVar1 = unnamed_function_1417(CloudsFly_Movement_ToHomeInitialWorldMovement_TypeInfo);
		  }
		  if (DAT_ram_00a5969c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Tween__TypeInfo);
		    DAT_ram_00a5969c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Tween__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Tween___ctor__);
		  *(undefined4 *)(iVar1 + 8) = param1_00;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007414")]
		[Address(RVA = "0xBDE2", Offset = "0xBDE2", VA = "0xBDE2")]
		private AbstractWorldMovement GetDefaultMovementByType(WorldMovementTypes type)
		{
			return null;
		}

		// Token: 0x04003CCF RID: 15567
		[Token(Token = "0x4003CCF")]
		[FieldOffset(Offset = "0x8")]
		private readonly IUserSettings _userSettings;
	}
}
