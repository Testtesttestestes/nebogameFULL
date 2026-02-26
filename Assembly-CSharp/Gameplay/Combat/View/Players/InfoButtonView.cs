using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000950 RID: 2384
	[Token(Token = "0x2000950")]
	public class InfoButtonView : MonoBehaviour, IGuideTargetResolveEventProvider, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x06003872 RID: 14450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003872")]
		[Address(RVA = "0x881C", Offset = "0x881C", VA = "0x881C", Slot = "7")]
		public void OnPointerDown(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerDown ---
		void Gameplay_Combat_View_Players_InfoButtonView__OnPointerDown
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a566ff == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a566ff = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x1400017E RID: 382
		// (add) Token: 0x06003873 RID: 14451 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003874 RID: 14452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017E")]
		public event Action<IGuideTargetResolveEventProvider> ResolveEvent
		{
			[Token(Token = "0x6003873")]
			[Address(RVA = "0x881D", Offset = "0x881D", VA = "0x881D", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003874")]
			[Address(RVA = "0x881E", Offset = "0x881E", VA = "0x881E", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003875")]
		[Address(RVA = "0x881F", Offset = "0x881F", VA = "0x881F")]
		public InfoButtonView()
		{
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003876")]
		[Address(RVA = "0x8820", Offset = "0x8820", VA = "0x8820", Slot = "6")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001F38 RID: 7992
		[Token(Token = "0x4001F38")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("_evt")]
		[SerializeField]
		private UnityEvent _onDownEvt;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ResolveEvent ---
		void Gameplay_Combat_View_Players_InfoButtonView__add_ResolveEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a56700 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a56700 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ResolveEvent ---
		void Gameplay_Combat_View_Players_InfoButtonView__remove_ResolveEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a56701 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityEvent_TypeInfo);
		    DAT_ram_00a56701 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityEvent_TypeInfo);
		  UnityEngine_Events_UnityAction__Invoke(param1_00,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

}
