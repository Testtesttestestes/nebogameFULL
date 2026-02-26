using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Fresco.View.Groups
{
	// Token: 0x020007FE RID: 2046
	[Token(Token = "0x20007FE")]
	public class FrescoGroupOSAView : OSADynamicBase<UserInFrescoGroupViewsHolder, FrescoGroupListElementArgs>
	{
		// Token: 0x06003004 RID: 12292 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003004")]
		[Address(RVA = "0x806A", Offset = "0x806A", VA = "0x806A", Slot = "119")]
		protected override UserInFrescoGroupViewsHolder CreateViewsHolder()
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Fresco_View_Groups_FrescoGroupOSAView__CreateViewsHolder
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57580 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSADynamicBase_UserInFrescoGroupViewsHolder__FrescoGroupListElementArgs___ctor__
		              );
		    DAT_ram_00a57580 = '\x01';
		  }
		  System_Nullable_TimeZoneInfo_TransitionTime___get_Value
		            (param1,
		             Method_UI_OSADynamicBase_UserInFrescoGroupViewsHolder__FrescoGroupListElementArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003005")]
		[Address(RVA = "0x806B", Offset = "0x806B", VA = "0x806B")]
		public FrescoGroupOSAView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_View_Groups_FrescoGroupOSAView___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a57581 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_View_Groups_FrescoGroupListElementArgs_TypeInfo);
		    DAT_ram_00a57581 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Fresco_View_Groups_FrescoGroupListElementArgs_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_Fresco_View_Groups_FrescoGroupListElementArgs_TypeInfo +
		                                0xb8) * 4 + -4) !=
		        Gameplay_Fresco_View_Groups_FrescoGroupListElementArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_Fresco_View_Groups_FrescoGroupListElementArgs_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a5757b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__get_Initted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__set_args__
		              );
		    DAT_ram_00a5757b = '\x01';
		  }
		  if (*(char *)(param1_00 + 0x1c) == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1_00,param2,
		               Method_UI_Elements_GenericList_GenericListElement_FrescoGroupListElementArgs__Init__)
		    ;
		    return;
		  }
		  *(int **)(param1_00 + 0x18) = param2;
		  Gameplay_Fresco_View_Groups_FrescoGroupListElement__ApplyArgs(param1_00,param2,param2);
		  return;
		}
		*/

		}
	}
}
