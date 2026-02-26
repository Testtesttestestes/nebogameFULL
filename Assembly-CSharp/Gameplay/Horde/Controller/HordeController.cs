using System;
using Gameplay.Horde.Events;
using Gameplay.Horde.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Horde.Controller
{
	// Token: 0x02000702 RID: 1794
	[Token(Token = "0x2000702")]
	public class HordeController : AbstractController<HordeModel, HordeEvents>
	{
		// Token: 0x06002AF1 RID: 10993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF1")]
		[Address(RVA = "0x7B8C", Offset = "0x7B8C", VA = "0x7B8C")]
		public HordeController(WorldService worldService, HordeModel model, HordeEvents events)
		{
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0x7B8D", Offset = "0x7B8D", VA = "0x7B8D", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Horde_Controller_HordeController__HandleRun
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a209 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_Controller_HordeController_GetHordeInfoResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a209 = '\x01';
		  }
		  uVar1 = ServicesNamespace_WorldService__KickFromIsle(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Horde_Controller_HordeController_GetHordeInfoResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF3")]
		[Address(RVA = "0x7B8E", Offset = "0x7B8E", VA = "0x7B8E")]
		public void GetHordeInfo(bool isCave)
		{
		/* --- GHIDRA: GetHordeInfo ---
		void Gameplay_Horde_Controller_HordeController__GetHordeInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a5a20a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_World_ProtoGetHordeInfoAns_TypeInfo);
		    DAT_ram_00a5a20a = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_World_ProtoGetHordeInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_World_ProtoGetHordeInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Horde_Model_HordeModel___ctor(param1_00,param1_01[3],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF4")]
		[Address(RVA = "0x7B8F", Offset = "0x7B8F", VA = "0x7B8F")]
		private void GetHordeInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetHordeInfoResultHandler ---
		void Gameplay_Horde_Controller_HordeController__GetHordeInfoResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a20b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Horde_Controller_HordeController_ExitHordeResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5a20b = '\x01';
		  }
		  uVar1 = ServicesNamespace_WorldService__GetHordeInfo(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Horde_Controller_HordeController_ExitHordeResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0x7B90", Offset = "0x7B90", VA = "0x7B90")]
		public void ExitHorde(bool isCave)
		{
		/* --- GHIDRA: ExitHorde ---
		void Gameplay_Horde_Controller_HordeController__ExitHorde
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0x7B91", Offset = "0x7B91", VA = "0x7B91")]
		private void ExitHordeResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: ExitHordeResultHandler ---
		void Gameplay_Horde_Controller_HordeController__ExitHordeResultHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5a20c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView___ctor__
		              );
		    DAT_ram_00a5a20c = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_HordeModel__HordeEvents__HordeController__HordeView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400177B RID: 6011
		[Token(Token = "0x400177B")]
		[FieldOffset(Offset = "0x18")]
		private readonly WorldService _service;
	}
}
