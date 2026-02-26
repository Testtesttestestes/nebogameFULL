using System;
using Gameplay.SpecialOffers.Events;
using Gameplay.SpecialOffers.Model;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.Controller
{
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	public class OptionsOfferController : OptionsOfferControllerBase<OptionsOfferModel, OptionsOfferEvents>
	{
		// Token: 0x06001EBC RID: 7868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x702F", Offset = "0x702F", VA = "0x702F")]
		public OptionsOfferController(OptionsOfferModel model, OptionsOfferEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SpecialOffers_Controller_OptionsOfferController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5863c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_BankOptionData___);
		    Mono_Security_ASN1__get_Item(&System_Func_BankOptionData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferController___c__HandleRun_b__1_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo);
		    DAT_ram_00a5863c = '\x01';
		  }
		  piVar2 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf0) * 4))
		                        (piVar2,*(undefined4 *)(*piVar2 + 0xf4));
		  if (*(int *)(Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)
		            (Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo);
		      puVar4 = *(undefined4 **)
		                (Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_BankOptionData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar5,param2_00,
		               Method_Gameplay_SpecialOffers_Controller_OptionsOfferController___c__HandleRun_b__1_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo + 0x5c)
		            + 4) = iVar5;
		  }
		  iVar5 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (param1_00,iVar5,Method_System_Linq_Enumerable_Any_BankOptionData___);
		  if (iVar5 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar2 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 400);
		          goto code_r0x80f17563;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x80f17563:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    Utils_CoroutineSource__StopCoroutine(*(undefined4 *)(iVar5 + 0x24),0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x7030", Offset = "0x7030", VA = "0x7030", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_SpecialOffers_Controller_OptionsOfferController__HandleRun(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5863d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo);
		    DAT_ram_00a5863d = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_SpecialOffers_Controller_OptionsOfferController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}
	}
}
