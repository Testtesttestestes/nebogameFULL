using System;
using Gameplay.Experiments.Events;
using Gameplay.Experiments.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Experiments.Controller
{
	// Token: 0x0200082D RID: 2093
	[Token(Token = "0x200082D")]
	public class ExperimentsController : AbstractController<ExperimentsModel, ExperimentsEvents>
	{
		// Token: 0x06003149 RID: 12617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003149")]
		[Address(RVA = "0x81A1", Offset = "0x81A1", VA = "0x81A1")]
		public ExperimentsController(ExperimentsModel model, ExperimentsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Experiments_Controller_ExperimentsController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Experiments_Controller_ExperimentsController__Dispose(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600314A RID: 12618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314A")]
		[Address(RVA = "0x81A2", Offset = "0x81A2", VA = "0x81A2", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Experiments_Controller_ExperimentsController__HandleRun(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5761e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ExperimentsModel__ExperimentsEvents__Dispose__);
		    DAT_ram_00a5761e = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_ExperimentsModel__ExperimentsEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x0600314B RID: 12619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314B")]
		[Address(RVA = "0x81A3", Offset = "0x81A3", VA = "0x81A3", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Experiments_Controller_ExperimentsController__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5761f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Experiments_Controller_ExperimentsController_HandleGetUserExperiments__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5761f = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__GetUserAntiqArtifacts(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Experiments_Controller_ExperimentsController_HandleGetUserExperiments__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600314C RID: 12620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314C")]
		[Address(RVA = "0x81A4", Offset = "0x81A4", VA = "0x81A4")]
		private void GetUserExperiments()
		{
		/* --- GHIDRA: GetUserExperiments ---
		void Gameplay_Experiments_Controller_ExperimentsController__GetUserExperiments
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a57620 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserExperimentsAns_TypeInfo);
		    DAT_ram_00a57620 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserExperimentsAns_TypeInfo != *param1_00)
		     ) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserExperimentsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = param1_00[3];
		  if (DAT_ram_00a5761b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserExperimentsAns_Types_Experiment__AddRange__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserExperimentsAns_Types_Experiment__Clear__
		              );
		    DAT_ram_00a5761b = '\x01';
		  }
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType___CalculateSize
		            (*(undefined4 *)(iVar1 + 0xc),
		             Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserExperimentsAns_Types_Experiment__Clear__
		            );
		  Google_Protobuf_Collections_RepeatedField_object___AddEntriesFrom
		            (*(undefined4 *)(iVar1 + 0xc),param2_00,
		             Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserExperimentsAns_Types_Experiment__AddRange__
		            );
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600314D RID: 12621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314D")]
		[Address(RVA = "0x81A5", Offset = "0x81A5", VA = "0x81A5")]
		private void HandleGetUserExperiments(OpToken<IMessage, object> opToken)
		{
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600314E")]
		[Address(RVA = "0x81A6", Offset = "0x81A6", VA = "0x81A6")]
		private void ValidateInit()
		{
		}

		// Token: 0x04001AE8 RID: 6888
		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;
	}
}
