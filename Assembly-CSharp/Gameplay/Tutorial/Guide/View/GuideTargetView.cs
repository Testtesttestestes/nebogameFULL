using System;
using System.Runtime.CompilerServices;
using Core;
using Gameplay.Tutorial.Guide.Control;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Tutorial.Guide.View
{
	// Token: 0x0200045F RID: 1119
	[Token(Token = "0x200045F")]
	public class GuideTargetView : MonoBehaviour, IGuideTarget, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x1400012F RID: 303
		// (add) Token: 0x06001A80 RID: 6784 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001A81 RID: 6785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400012F")]
		private event Action<IGuideTarget> _resolveEvent
		{
			[Token(Token = "0x6001A80")]
			[Address(RVA = "0x6C14", Offset = "0x6C14", VA = "0x6C14")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001A81")]
			[Address(RVA = "0x6C15", Offset = "0x6C15", VA = "0x6C15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000130 RID: 304
		// (add) Token: 0x06001A82 RID: 6786 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001A83 RID: 6787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000130")]
		public event Action<IGuideTarget> ResolveEvent
		{
			[Token(Token = "0x6001A82")]
			[Address(RVA = "0x6C16", Offset = "0x6C16", VA = "0x6C16", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x6001A83")]
			[Address(RVA = "0x6C17", Offset = "0x6C17", VA = "0x6C17", Slot = "5")]
			remove
			{
			}
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A84")]
		[Address(RVA = "0x6C18", Offset = "0x6C18", VA = "0x6C18")]
		private void HandleEvtProviderResolveEvent(IGuideTargetResolveEventProvider eventProvider)
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001A86 RID: 6790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049E")]
		public string Id
		{
			[Token(Token = "0x6001A85")]
			[Address(RVA = "0x6C19", Offset = "0x6C19", VA = "0x6C19", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A86")]
			[Address(RVA = "0x6C1A", Offset = "0x6C1A", VA = "0x6C1A")]
			set
			{
			}
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6001A87")]
		[Address(RVA = "0x6C1B", Offset = "0x6C1B", VA = "0x6C1B", Slot = "7")]
		public Rect GetRect(Camera camera)
		{
			return default(Rect);
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700049F")]
		public MonoBehaviour MonoBehaviour
		{
			[Token(Token = "0x6001A88")]
			[Address(RVA = "0x6C1C", Offset = "0x6C1C", VA = "0x6C1C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x6001A89")]
		[Address(RVA = "0x6C1D", Offset = "0x6C1D", VA = "0x6C1D", Slot = "12")]
		public virtual bool CheckParams(params long[] values)
		{
			return default(bool);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6001A8A")]
		public bool TryGetOverrides<T>(out T component)
		{
			return default(bool);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A0")]
		public RectTransform Transform
		{
			[Token(Token = "0x6001A8B")]
			[Address(RVA = "0x6C1E", Offset = "0x6C1E", VA = "0x6C1E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A1")]
		public IAsyncLoadableContent AsyncContent
		{
			[Token(Token = "0x6001A8C")]
			[Address(RVA = "0x6C1F", Offset = "0x6C1F", VA = "0x6C1F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A2")]
		private IGuideTargetResolveEventProvider EvtProvider
		{
			[Token(Token = "0x6001A8D")]
			[Address(RVA = "0x6C20", Offset = "0x6C20", VA = "0x6C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004A3")]
		public GuideController Controller
		{
			[Token(Token = "0x6001A8E")]
			[Address(RVA = "0x6C21", Offset = "0x6C21", VA = "0x6C21")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A8F")]
		[Address(RVA = "0x6C22", Offset = "0x6C22", VA = "0x6C22")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A90")]
		[Address(RVA = "0x6C23", Offset = "0x6C23", VA = "0x6C23")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A91")]
		[Address(RVA = "0x6C24", Offset = "0x6C24", VA = "0x6C24")]
		private void OnDisable()
		{
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x6C25", Offset = "0x6C25", VA = "0x6C25")]
		private void TryAdd()
		{
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x6C26", Offset = "0x6C26", VA = "0x6C26")]
		private void TryRemove()
		{
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x6C27", Offset = "0x6C27", VA = "0x6C27")]
		private void HandleAsyncLoadableContentReadyEvent(IAsyncLoadableContent content)
		{
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A95")]
		[Address(RVA = "0x6C28", Offset = "0x6C28", VA = "0x6C28", Slot = "11")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x6C29", Offset = "0x6C29", VA = "0x6C29")]
		public GuideTargetView()
		{
		}

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _id;

		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform _rectTransform;

		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x1C")]
		private IAsyncLoadableContent _asyncContent;

		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		[FieldOffset(Offset = "0x20")]
		private IGuideTargetResolveEventProvider _evtProvider;

		// Token: 0x04000E54 RID: 3668
		[Token(Token = "0x4000E54")]
		[FieldOffset(Offset = "0x24")]
		private GuideController _controller;
	}
}
