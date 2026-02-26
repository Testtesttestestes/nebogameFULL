using System;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Manufacture.Control;
using Gameplay.Assistants.Manufacture.Model;
using Gameplay.Assistants.Manufacture.View;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Assistants.Manufacture
{
	// Token: 0x02000CA9 RID: 3241
	[Token(Token = "0x2000CA9")]
	public class ManufactureAssistant : Assistant<ManufactureAssistModel>
	{
		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06004EDB RID: 20187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EDC RID: 20188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FFC")]
		public ManufactureAssistController Controller
		{
			[Token(Token = "0x6004EDB")]
			[Address(RVA = "0x9D03", Offset = "0x9D03", VA = "0x9D03")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EDC")]
			[Address(RVA = "0x9D04", Offset = "0x9D04", VA = "0x9D04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FFD")]
		public override ManufactureAssistModel Model
		{
			[Token(Token = "0x6004EDD")]
			[Address(RVA = "0x9D05", Offset = "0x9D05", VA = "0x9D05", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x9D06", Offset = "0x9D06", VA = "0x9D06", Slot = "6")]
		protected override void HandleRun(AssistantStatus status)
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Assistants_Manufacture_ManufactureAssistant__HandleRun(int param1,undefined4 param2)
		
		{
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EDF")]
		[Address(RVA = "0x9D07", Offset = "0x9D07", VA = "0x9D07", Slot = "7")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Assistants_Manufacture_ManufactureAssistant__HandleStop(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined8 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE0")]
		[Address(RVA = "0x9D08", Offset = "0x9D08", VA = "0x9D08", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int * Gameplay_Assistants_Manufacture_ManufactureAssistant__Dispose
		                (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param4;
		  int iVar1;
		  
		  if (DAT_ram_00a58979 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_TypeInfo
		              );
		    DAT_ram_00a58979 = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x14);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x100) * 4))
		                        (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0x104));
		  iVar1 = **(int **)(param1 + 0x14);
		  param3_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x110) * 4))
		                        (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0x114));
		  param4 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = (int *)unnamed_function_1417
		                               (
		                               Gameplay_Assistants_Manufacture_Control_ManufactureAssistViewInAccountViewMediator_TypeInfo
		                               );
		  if (DAT_ram_00a589a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView___ctor__
		              );
		    DAT_ram_00a589a5 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_ManufactureAssistModel__ManufactureAssistantEvents__ManufactureAssistController__ManufactureViewInAccountView___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param2,*(undefined4 *)(*param1_00 + 0x164));
		  return param1_00;
		}
		*/

		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004EE1")]
		[Address(RVA = "0x9D09", Offset = "0x9D09", VA = "0x9D09")]
		public ManufactureAssistViewInAccountViewMediator CreateMeditor(ManufactureViewInAccountView view)
		{
		/* --- GHIDRA: CreateMeditor ---
		void Gameplay_Assistants_Manufacture_ManufactureAssistant__CreateMeditor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5897a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Assistants_Assistant_ManufactureAssistModel___ctor__);
		    DAT_ram_00a5897a = '\x01';
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EE2")]
		[Address(RVA = "0x9D0A", Offset = "0x9D0A", VA = "0x9D0A")]
		public ManufactureAssistant()
		{
		}

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x18")]
		private ManufactureAssistModel _model;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Model ---
		void Gameplay_Assistants_Manufacture_ManufactureAssistant__get_Model
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a58978 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Assistants_Manufacture_ManufactureAssistantEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CraftService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58978 = '\x01';
		  }
		  iVar5 = param1[2];
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80f50601;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f50601:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar6 = unnamed_function_1417
		                    (Gameplay_Assistants_Manufacture_Model_ManufactureAssistModel_TypeInfo);
		  if (DAT_ram_00a58977 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a58977 = '\x01';
		  }
		  uVar4 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar4,0.0,0);
		  *(undefined4 *)(iVar6 + 0x18) = uVar4;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar6,uVar3,0);
		  *(undefined4 *)(iVar6 + 0x14) = param2;
		  *(int *)(iVar6 + 0x10) = iVar5;
		  *(int **)(iVar6 + 0xc) = param1_00;
		  param1[6] = iVar6;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = unnamed_function_1417(Gameplay_Assistants_Manufacture_ManufactureAssistantEvents_TypeInfo)
		  ;
		  iVar5 = unnamed_function_1417
		                    (Gameplay_Assistants_Manufacture_Control_ManufactureAssistController_TypeInfo);
		  if (DAT_ram_00a58986 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractController_ManufactureAssistModel__ManufactureAssistantEvents___ctor__
		              );
		    DAT_ram_00a58986 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar5,uVar3,uVar4,
		             Method_MVC_AbstractController_ManufactureAssistModel__ManufactureAssistantEvents___ctor__
		            );
		  param1[5] = iVar5;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CraftService___);
		  *(undefined4 *)(iVar5 + 0x1c) = uVar3;
		  iVar5 = param1[5];
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  *(undefined4 *)(iVar5 + 0x18) = uVar3;
		  MVC_AbstractController__Dispose(param1[5],0);
		  return;
		}
		*/

}
