using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001354 RID: 4948
	[Token(Token = "0x2001354")]
	public class BaseSpecializationManager
	{
		// Token: 0x0600757F RID: 30079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600757F")]
		[Address(RVA = "0xBF0F", Offset = "0xBF0F", VA = "0xBF0F", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		/* --- GHIDRA: InitializeSpecializations ---
		undefined4
		I2_Loc_BaseSpecializationManager__InitializeSpecializations(int *param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59723 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12098);
		    DAT_ram_00a59723 = '\x01';
		  }
		  if (param1[2] == 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  }
		  return StringLiteral_12098;
		}
		*/

		}

		// Token: 0x06007580 RID: 30080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007580")]
		[Address(RVA = "0xBF10", Offset = "0xBF10", VA = "0xBF10", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
		/* --- GHIDRA: GetCurrentSpecialization ---
		uint I2_Loc_BaseSpecializationManager__GetCurrentSpecialization(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63c4c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Touchscreen_TypeInfo);
		    DAT_ram_00a63c4c = '\x01';
		  }
		  return (uint)(**(int **)(UnityEngine_InputSystem_Touchscreen_TypeInfo + 0x5c) != 0);
		}
		*/

			return null;
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x000152B8 File Offset: 0x000134B8
		[Token(Token = "0x6007581")]
		[Address(RVA = "0xBF11", Offset = "0xBF11", VA = "0xBF11")]
		private bool IsTouchInputSupported()
		{
		/* --- GHIDRA: IsTouchInputSupported ---
		undefined4
		I2_Loc_BaseSpecializationManager__IsTouchInputSupported
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59724 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3154);
		    DAT_ram_00a59724 = '\x01';
		  }
		  local_4 = 0;
		  puVar1 = &local_4;
		  iVar2 = param1[3];
		  if (iVar2 == 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		    iVar2 = param1[3];
		  }
		  iVar2 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (iVar2,param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_string__string__TryGetValue__);
		  if (iVar2 == 0) {
		    puVar1 = &StringLiteral_3154;
		  }
		  return *puVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007582")]
		[Address(RVA = "0xBF12", Offset = "0xBF12", VA = "0xBF12", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007583")]
		[Address(RVA = "0xBF13", Offset = "0xBF13", VA = "0xBF13")]
		public BaseSpecializationManager()
		{
		}

		// Token: 0x04003D5D RID: 15709
		[Token(Token = "0x4003D5D")]
		[FieldOffset(Offset = "0x8")]
		public string[] mSpecializations;

		// Token: 0x04003D5E RID: 15710
		[Token(Token = "0x4003D5E")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<string, string> mSpecializationsFallbacks;
	}
}
