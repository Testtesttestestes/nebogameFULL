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
}
